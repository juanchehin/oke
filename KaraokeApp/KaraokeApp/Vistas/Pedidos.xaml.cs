using KaraokeApp.Modelo;
using KaraokeApp.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup.Interfaces.Animations;

namespace KaraokeApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pedidos : ContentPage
    {
        public Pedidos()
        {
            InitializeComponent();
            BindingContext = new VMcanciones();      
        }
        int IdMesa = 0;
        int IdCancion = 0;
        private CancellationTokenSource TimerCancelar;
        //Este scaner no enciende el Flash, se deja para que lo ocupen si es que desean
        private async void ScannerSimple()
        {
            ZXingScannerPage PaginaEscaneo = new ZXingScannerPage();
            PaginaEscaneo.Title = "Escanea el codigo QR de tu mesa";
            PaginaEscaneo.OnScanResult += (resultado) =>
            {
                PaginaEscaneo.IsScanning = false;
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    string idCapturado;
                    idCapturado = resultado.Text;
                    string cadena = idCapturado;
                    string[] separadas = cadena.Split('|');
                    string IdProcesado = separadas[1];
                    IdMesa =Convert.ToInt32( IdProcesado);
                    Insertar_Pedidos();
                });
            };
            await Navigation.PushAsync(PaginaEscaneo);
        }
        async public Task<string> EscannerFlash(bool flashOn)
        {
            TimerCancelar = new CancellationTokenSource();
            MobileBarcodeScanner escaneo = new MobileBarcodeScanner();
            escaneo.BottomText = "Escanea el codigo QR de tu mesa";
            ZXing.Result resultado = null;
            CancellationTokenSource controlCancelado = TimerCancelar;
            TimeSpan ts = new TimeSpan(0,0,0,2,0);
            Device.StartTimer(ts, () =>
             {
                 if(controlCancelado.IsCancellationRequested)
                 {
                     return false;
                 }
                 if (resultado == null)
                 {
                     escaneo.AutoFocus();
                     if(flashOn)
                     {
                         escaneo.Torch(true);
                     }
                     return true;
                 }
                 return false;
             });
            resultado = await escaneo.Scan();
            if(resultado!=null)
            {
                await Stop();
                string idCapturado;
                idCapturado = resultado.Text;
                string cadena = idCapturado;
                string[] separadas = cadena.Split('|');
                string IdProcesado = separadas[1];
                IdMesa = Convert.ToInt32(IdProcesado);
                Insertar_Pedidos();
            }
            await Stop();
            return string.Empty;
        }
        async private Task Stop()
        {
            await Task.Run(() => { Interlocked.Exchange(ref this.TimerCancelar, new CancellationTokenSource()).Cancel(); });

        }
        private async void Insertar_Pedidos()
        {
            Mpedidos parametros = new Mpedidos();
            VMpedidos funcion = new VMpedidos();
            parametros.IdCancion = IdCancion;
            parametros.IdMesa = IdMesa;
            if(funcion.Insertar_Pedidos(parametros)==true)
            {
                await PopupNavigation.Instance.PushAsync(new PedidoRealizado());
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new LimitePedidos());
            }
        }
        public void  BuscarCanciones()
        {
            try
            {
                VMcanciones funcion = new VMcanciones();
                PanelCanciones.ItemsSource = funcion.ListarBuscarCanciones(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void txtBuscar_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {        
                BuscarCanciones();
        }

        private async void btnPedir_ClickedAsync(object sender, EventArgs e)
        {
            IdCancion =Convert.ToInt32 ( (sender as Button).CommandParameter.ToString());
            await EscannerFlash(true);
        }

        private  void btnFelizcumple_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FelizCumple());
   
        }

        private async void btnAcercade_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new AcercaDe());
        }
    }
}