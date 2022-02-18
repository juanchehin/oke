using okeApp.VistaModelo;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace okeApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Introduccion : ContentPage
    {
        public Introduccion()
        {
            InitializeComponent();
            Animacion();
        }
        int IdCancion = 0;
        bool retorno = false;
        public async Task Animacion()
        {
            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 2000);
            // Application.Current.MainPage = new NavigationPage(new Pedidos());
            ProbarConexion();
        }
        private void ProbarConexion()
        {
            try
            {
                // VMcanciones funcion = new VMcanciones();
                PedidoIP funcion = new PedidoIP();

                retorno = funcion.crear_archivo();
            }
            catch (Exception)
            {
                IdCancion = 0;
            }
            if (retorno == false)
            {
                Application.Current.MainPage = new NavigationPage(new Pedidos());

            }
            else
            {
                Application.Current.MainPage = new NavigationPage(new PedidoIP());
            }
        }
    }
}