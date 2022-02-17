using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace okeApp.Vistas
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
            while (true)
            {
                bvGradiente.Animate(name: "frontal", callback: frontal, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bvGradiente.Animate(name: "atras", callback: atras, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }

    }
}