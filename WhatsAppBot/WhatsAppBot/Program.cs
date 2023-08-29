

using log4net.Config;
using log4net;
using System.Reflection;
using WhatsAppBot.Repositories;
using WhatsAppBot.Service;
using Microsoft.Extensions.Configuration;
using WhatsAppBot.Util;

RepositoryBase repositoryBase = new RepositoryBase();
AlertaRepository alertaRepository = new AlertaRepository(repositoryBase);
ApiTemplateService apiTemplateService = new ApiTemplateService(alertaRepository);
CreateTemplateService createTemplateService = new CreateTemplateService(apiTemplateService);

SendMessageService sendMessageService = new SendMessageService(alertaRepository, new HttpClient(),
    createTemplateService);


LogConfig.ConfigureLog4net();


await sendMessageService.SendMessage();