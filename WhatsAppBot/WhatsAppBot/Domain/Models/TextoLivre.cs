using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppBot.Domain.Models
{
    public class TextoLivre
    {
            
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        [JsonProperty("recipient_type")]
        public string RecipientType { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public MessageText Text { get; set; }
    }

    public class MessageText
    {
        [JsonProperty("preview_url")]
        public bool PreviewUrl { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}

