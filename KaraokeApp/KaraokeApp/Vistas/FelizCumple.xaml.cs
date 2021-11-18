using KaraokeApp.Modelo;
using KaraokeApp.VistaModelo;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;

namespace KaraokeApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FelizCumple : ContentPage
    {
        public FelizCumple()
        {
            InitializeComponent();
            Task.Run(AnimacionDegradado);
        }
        int IdMesa = 0;
        private CancellationTokenSource TimerCancelar;
        private async void AnimacionDegradado()
        {
            Action<double> frontal = input => bvGradiente.AnchorY = input;
            Action<double> atras = input => bvGradiente.AnchorY = input;
            while(true)
            {
                bvGradiente.Animate(name: "frontal", callback: frontal, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bvGradiente.Animate(name: "atras", callback: atras, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }

        private async void btnPedir_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSaludo.Text))
            {
                await EscannerFlash(true);
            }
            else
            {
                await DisplayAlert("Error", "Ingrese su saludo", "OK");
            }
        }
        async public Task<string> EscannerFlash(bool flashOn)
        {
            TimerCancelar = new CancellationTokenSource();
            MobileBarcodeScanner escaneo = new MobileBarcodeScanner();
            escaneo.BottomText = "Escanea el codigo QR de tu mesa";
            ZXing.Result resultado = null;
            CancellationTokenSource controlCancelado = TimerCancelar;
            TimeSpan ts = new TimeSpan(0, 0, 0, 2, 0);
            Device.StartTimer(ts, () =>
            {
                if (controlCancelado.IsCancellationRequested)
                {
                    return false;
                }
                if (resultado == null)
                {
                    escaneo.AutoFocus();
                    if (flashOn)
                    {
                        escaneo.Torch(true);
                    }
                    return true;
                }
                return false;
            });
            resultado = await escaneo.Scan();
            if (resultado != null)
            {
                await Stop();
                string idCapturado;
                idCapturado = resultado.Text;
                string cadena = idCapturado;
                string[] separadas = cadena.Split('|');
                string IdProcesado = separadas[1];
                IdMesa = Convert.ToInt32(IdProcesado);
                Insertar_cumpleaños();
            }
            await Stop();
            return string.Empty;
        }
        async private Task Stop()
        {
            await Task.Run(() => { Interlocked.Exchange(ref this.TimerCancelar, new CancellationTokenSource()).Cancel(); });

        }
        private async void Insertar_cumpleaños()
        {
            Mpedidos parametros = new Mpedidos();
            VMpedidos funcion = new VMpedidos();
            parametros.IdMesa = IdMesa;
            parametros.Mensaje = txtSaludo.Text;
            if(funcion.insertar_cumpleanios(parametros)==true)
            {
                await PopupNavigation.Instance.PushAsync(new PedidoRealizado());
                await Navigation.PopAsync();

            }
        }
    }
}