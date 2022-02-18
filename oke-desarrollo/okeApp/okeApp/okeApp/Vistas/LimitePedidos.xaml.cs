using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace okeApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LimitePedidos : PopupPage
    {
        public LimitePedidos()
        {
            InitializeComponent();
        }
        private async void btnOk_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAllAsync();
        }
    }
}