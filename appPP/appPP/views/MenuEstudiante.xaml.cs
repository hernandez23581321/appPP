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
    public partial class MenuEstudiante : ContentPage
    {
        public MenuEstudiante()
        {
            InitializeComponent();
        }

        private async  void TappedEvaluaciones(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Evaluaciones(),true);
        }

        private async void CerrarSesionTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);

            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void ListaMateriasTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaMaterias());

        }
    }
}