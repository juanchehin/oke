using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KaraokeApp.Vistas;
namespace KaraokeApp
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
