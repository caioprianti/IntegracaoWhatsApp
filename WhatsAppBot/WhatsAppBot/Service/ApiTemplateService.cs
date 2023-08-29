using System;
using System.Collections.Generic;
using WhatsAppBot.Domain.Entities;
using WhatsAppBot.Domain.Models;
using WhatsAppBot.Repositories;

namespace WhatsAppBot.Service
{
    public class ApiTemplateService
    {
        private readonly AlertaRepository _alertaRepository;

        public ApiTemplateService(AlertaRepository alertaRepository)
        {
            _alertaRepository = alertaRepository;
        }

        public ApiTemplate CreateApiTemplate()
        {
            ApiTemplate apiTemplate = new ApiTemplate();

            var alerta = _alertaRepository.getMessages();

            if (alerta != null && alerta.Count > 0)
            {
                var firstParameter = new Parameter
                {
                    Type = "text",
                    Text = alerta[0].nome
                };

                var secondParameter = new Parameter
                {
                    Type = "text",
                    Text = "1"
                };

                var component = new Component
                {
                    Type = "body"
                };

                component.Parameters.Add(firstParameter);
                component.Parameters.Add(secondParameter);

                var language = new Language
                {
                    Code = "pt_BR"
                };

                var template = new Template
                {
                    Name = "api",
                    Language = language
                };

                template.Components.Add(component);

                apiTemplate.MessagingProduct = "whatsapp";
                apiTemplate.To = "55" + alerta[0].telefone;
                apiTemplate.Type = "template";
                apiTemplate.Template = template;

                return apiTemplate;
            }

            return null; 
        }
    }
}
