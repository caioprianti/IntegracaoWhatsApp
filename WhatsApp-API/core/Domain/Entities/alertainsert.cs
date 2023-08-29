using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace core.Domain.Entities
{
    public class alertaInsert
    {
        [JsonProperty(PropertyName = "canal")]
        public string canal { get; set; }
        [JsonProperty(PropertyName = "acao")]
        public string acao { get; set; }
        [JsonProperty(PropertyName = "mensagem")]
        public string mensagem { get; set; }
        [JsonProperty(PropertyName = "tipo")]
        public string tipo { get; set; }
        [JsonProperty(PropertyName = "nome")]
        public string nome { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }
        [JsonProperty(PropertyName = "telefone")]
        public string telefone { get; set; }

    }
}

