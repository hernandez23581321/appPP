using appPP.Clases;
using appPP.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appPP.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Materias : ContentPage
    {
        public Materias()
        {
            InitializeComponent();


        }
        public async void GuardarMateria()
        {
            var materias = new MateriasModel()
            {
                codigo_materia= codigoMateria.Text,
                materia=nombreMateria.Text,
                descripcion=descripcionMateria.Text,
                estado=true,
           
            };
            refresc.IsRunning = true;
            refresc.IsVisible = true;
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(materias);
            var contentJSON = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Constants.URLMaterias, contentJSON);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                await DisplayAlert("Datos", "Se guardo nueva materia", "OK");
              

                refresc.IsRunning = false;
                refresc.IsVisible = false;
            }
        }

        private void saveMateria(object sender, EventArgs e)
        {
            GuardarMateria();
        }
    }
}