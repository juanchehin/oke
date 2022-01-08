using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public async Task Animacion()
        {
            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 2000);
            Application.Current.MainPage = new NavigationPage(new Pedidos());
            //ProbarConexion();
        }
        /*private void ProbarConexion()
        {
            try
            {
                VMcanciones funcion = new VMcanciones();
                funcion.ComprobarConexion(ref Idcancion);
            }
            catch (Exception)
            {
                Idcancion = 0;
            }
            if (Idcancion > 0)
            {
                Application.Current.MainPage = new NavigationPage(new Pedidos());

            }
            else
            {
                Application.Current.MainPage = new NavigationPage(new PedidoIP());
            }
        }*/
    }
}