using appPP.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace appPP.Service
{
    public class RestServiceMaterias
    {

        HttpClient cliente;

        public RestServiceMaterias()
        {
            cliente = new HttpClient();


        }

        public async Task<List<MateriasModel>> GetRepositoriesAsync(string url)
        {
            List<MateriasModel> lista = null;
            try
            {
                HttpResponseMessage respuesta = await cliente.GetAsync(url);
                if (respuesta.IsSuccessStatusCode)
                {
                    string informacion = await respuesta.Content.ReadAsStringAsync();
                    lista = JsonConvert.DeserializeObject<List<MateriasModel>>(informacion);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error", ex.Message);
            }

            return lista;
        }



        public async Task<List<MateriasModel>> DeleteTodoItemAsync(string url)
        {
            List<MateriasModel> lista = null;


            HttpResponseMessage response = await cliente.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {

            }
            return lista;
        }


        public async Task PostUser(MateriasModel materias, string url)
        {

            var json = JsonConvert.SerializeObject(materias);
            var contentJSON = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await cliente.PostAsync(url, contentJSON);

        }
    }
}
