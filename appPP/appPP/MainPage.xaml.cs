using appPP.Clases;
using appPP.Model;
using appPP.Service;
using appPP.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Xamarin.Forms;

namespace appPP
{
    public partial class MainPage : ContentPage
    {
        List<User> service;
        RestService restService;
        protected override bool OnBackButtonPressed() { return true; }
        public MainPage()
        {
            InitializeComponent();
            restService = new RestService();
            Device.SetFlags(new string[] { "MediaElement_Experimental" });


        }

        private async void IniciarSesion(object sender, EventArgs e)
        {
            //

            if (usuario.Text =="1" )
            {
                await Navigation.PushAsync(new MenuEstudiante());
            }
            else if (usuario.Text == "2")
            {
                await Navigation.PushAsync(new MenuCatedratico());
            }
            else
            {
                await Navigation.PushAsync(new Matricula());
            }
           
            /*  service = await restService.GetRepositoriesAsync(Constants.URL);

              if (service == null)
              {
                  indicador.IsRunning = true;
                  indicador.IsVisible = true;
                  return;
              }
              else
              {
                  if (usuario.Text.Equals(service.FirstOrDefault().codigo_estudiante) && password.Text.Equals(service.FirstOrDefault().password))
                  {
                      indicador.IsRunning = false;
                      indicador.IsVisible = false;
                      await Navigation.PushAsync(new Matricula());

                  }
              }
             */
        }

    }
}
