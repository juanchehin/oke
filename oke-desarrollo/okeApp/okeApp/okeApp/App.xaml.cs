using okeApp.Vistas;
using Xamarin.Forms;

namespace okeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Brush_Experimental" });
            MainPage = new Introduccion();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
