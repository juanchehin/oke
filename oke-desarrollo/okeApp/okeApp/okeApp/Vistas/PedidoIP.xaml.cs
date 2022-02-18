using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;

namespace okeApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PedidoIP : ContentPage
    {
        public PedidoIP()
        {
            InitializeComponent();
        }
        string ruta;
        string ip;
        int Idcancion;
        private CancellationTokenSource TimerCancelar;
        string parte1 = "Data source =";
        string parte2 = ";Initial Catalog=oke;Integrated Security=false;User Id=okeSQL;Password=okeSQ12";
        string cadena_de_conexion;
        bool retorno = false;

        private async void btnEscanear_ClickedAsync(object sender, EventArgs e)
        {
            await EscannerFlash(true);
        }
        private void btnConectar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtconexion.Text))
            {
                ProbarConexion();
                ValidarConexion();
            }
            else
            {
                DisplayAlert("Ingrese la conexion", "Sin datos", "OK");
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
                string conexion = separadas[2];
                txtconexion.Text = conexion;
                ProbarConexion();
                ValidarConexion();
            }
            await Stop();
            return string.Empty;
        }

        private async void ValidarConexion()
        {
            if (Idcancion > 0)
            {
                crear_archivo();
                await DisplayAlert("!Listo!", "Vuelva a abrir la aplicacion", "OK");
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
            else
            {
                await DisplayAlert("!Sin conexion!", "Pida una conexion valida", "OK");

            }
        }
        private void ProbarConexion()
        {
            cadena_de_conexion = parte1 + txtconexion.Text + parte2;
            try
            {
                SqlConnection conexionmanual = new SqlConnection(cadena_de_conexion);
                conexionmanual.Open();
                SqlCommand cmd = new SqlCommand("Select Top 1 IdCancion from Canciones", conexionmanual);
                Idcancion = Convert.ToInt32(cmd.ExecuteScalar());
                conexionmanual.Close();
            }
            catch (Exception)
            {
                Idcancion = 0;
                DisplayAlert("Error", "Sin conexion", "OK");
            }
        }
        async private Task Stop()
        {
            await Task.Run(() => { Interlocked.Exchange(ref this.TimerCancelar, new CancellationTokenSource()).Cancel(); });

        }
        public bool crear_archivo()
        {
            retorno = false;
            ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "connection.txt");
            FileInfo fi = new FileInfo(ruta);
            StreamWriter sw;
            try
            {

                if (File.Exists(ruta) == false)
                {
                    sw = File.CreateText(ruta);
                    sw.WriteLine(parte1 + txtconexion.Text + parte2);
                    sw.Flush();
                    sw.Close();
                    retorno = true;
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(parte1 + txtconexion.Text + parte2);
                    sw.Flush();
                    sw.Close();
                    retorno = false;
                }
            }
            catch (Exception)
            {

            }
            return retorno;
        }
    }
   
}