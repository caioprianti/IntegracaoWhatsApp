using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WhatsAppBot.Domain.Models
{
    public class Language
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class Parameter
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Component
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parameters")]
        public List<Parameter> Parameters { get; set; }

        public Component()
        {
            Parameters = new List<Parameter>();
        }
    }

    public class Template
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("components")]
        public List<Component> Components { get; set; }

        public Template()
        {
            Components = new List<Component>();
        }
    }

    public class ApiTemplate
    {
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("template")]
        public Template Template { get; set; }
    }
}
