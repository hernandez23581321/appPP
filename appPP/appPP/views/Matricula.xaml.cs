using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appPP.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Matricula : ContentPage
    {
        public Matricula()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevaMatricula(),true);

        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Catedraticos());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grados());

        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Materias());

        }

        private async void politica_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Parciales());
        }
        private async void CerrarSesionTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}