using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WhatsAppBot.Domain.Entities
{
    public class Alerta
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("canal")]
        public string canal { get; set; }

        [JsonProperty("acao")]
        public string acao { get; set; }

        [JsonProperty("mensagem")]
        public string mensagem { get; set; }

        [JsonProperty("tipo")]
        public string tipo { get; set; }

        [JsonProperty("dataenvio")]
        public DateTime dataenvio { get; set; }

        [JsonProperty("dataconfirmacao")]
        public DateTime dataconfirmacao { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("telefone")]
        public string telefone { get; set; }

        [JsonProperty("Json")]
        public string Json { get; set; }

        [JsonProperty("MessageId")]
        public string MessageId { get; set; }
    }
}
