using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppBot.Domain.Models;

namespace WhatsAppBot.Service
{
    public class CreateTemplateService
    {
        private readonly ApiTemplateService _apiTemplateService;
        
        public CreateTemplateService(ApiTemplateService apiTemplateService)
        {
            _apiTemplateService = apiTemplateService;
        }
       public ApiTemplate GetTemplate(string name)
        {
            switch (name)
            {
                //ajustar para os templates corretos após definição e criação
                case "alerta":
                    Console.WriteLine( "api ainda não criada");
                    return null;

                case "api":
                    return _apiTemplateService.CreateApiTemplate();

                default:
                    Console.WriteLine( "invalid template name");
                    return null;
            }
        }

    }
}
