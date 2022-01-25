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
    public class RestService
    {
        HttpClient cliente;

        public RestService()
        {
            cliente = new HttpClient();


        }

        public async Task<List<User>> GetRepositoriesAsync(string url)
        {
            List<User> lista = null;
            try
            {
                HttpResponseMessage respuesta = await cliente.GetAsync(url);
                if (respuesta.IsSuccessStatusCode)
                {
                    string informacion = await respuesta.Content.ReadAsStringAsync();
                    lista = JsonConvert.DeserializeObject<List<User>>(informacion);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error", ex.Message);
            }

            return lista;
        }



        public async Task<List<User>> DeleteTodoItemAsync(string url)
        {
            List<User> lista = null;


            HttpResponseMessage response = await cliente.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {

            }
            return lista;
        }


        public async Task PostUser(User user, string url)
        {

            var json = JsonConvert.SerializeObject(user);
            var contentJSON = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await cliente.PostAsync(url, contentJSON);

        }

    }
}