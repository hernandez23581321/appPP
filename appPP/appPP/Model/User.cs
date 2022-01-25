using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace appPP.Model
{
    public class User
    {
        [JsonProperty("codigo_estudiante")]
        public string codigo_estudiante { get; set; }
        [JsonProperty("password")]
        public string password { get; set; }
        [JsonProperty("codigo_matricula")]
        public int codigo_matricula { get; set; }
        [JsonProperty("estado")]
        public int estado { get; set; }
     


    }
}
