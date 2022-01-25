using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace appPP.Model
{
    public class MateriasModel
    {

        [JsonProperty("codigo_materia")]
        public string codigo_materia { get; set; }
        [JsonProperty("materia")]
        public string materia { get; set; }
        [JsonProperty("codigo_matricula")]
        public string descripcion { get; set; }
        [JsonProperty("estado")]
        public Boolean estado { get; set; }
      
       

    }
}
