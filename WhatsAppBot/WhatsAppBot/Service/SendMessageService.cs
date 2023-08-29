using log4net;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WhatsAppBot.Domain.Entities;
using WhatsAppBot.Domain.Models;
using WhatsAppBot.Repositories;

namespace WhatsAppBot.Service
{
    public class SendMessageService
    {
        private readonly AlertaRepository _alertaRepository;
        private readonly HttpClient _httpClient;
        private readonly CreateTemplateService _createTemplateService;
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public SendMessageService(AlertaRepository alertaRepository, HttpClient httpCliente,
            CreateTemplateService createTemplateService)
        {
            _alertaRepository = alertaRepository;
            _httpClient = httpCliente;
            _createTemplateService = createTemplateService;
        }

        public async Task SendMessage()
        {
            List<Alerta> lista = _alertaRepository.getMessages();

            _log.Info("Gerando lista de mensagens a serem enviadas");

            var appSettings = ConfigurationManager.AppSettings;
            var url = appSettings.Get("SendMessageUrl");
            var token = appSettings.Get("Token");
            var path = appSettings.Get("Path");

            try
            {
                foreach (Alerta alerta in lista)
                {
                    var template = _createTemplateService.GetTemplate(alerta.acao);
                    if (template != null)
                    {
                        string jsonBody = JsonConvert.SerializeObject(template);
                        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await _httpClient.PostAsync(url, content);
                        string responsevalue = await response.Content.ReadAsStringAsync();

                        _log.Info($"Response Value: {responsevalue}");
                        _log.Info($"Json body: {jsonBody}");

                        var objectResponse = JsonConvert.DeserializeObject<ResponseValue>(responsevalue);

                        if (response.IsSuccessStatusCode && objectResponse?.Messages[0].Id != null)
                        {
                            string id = objectResponse.Messages[0].Id;
                            _alertaRepository.UpdateTable(alerta, jsonBody, id);
                        }
                        else
                        {
                            _alertaRepository.UpdateTable(alerta, jsonBody, (response.StatusCode.ToString() +
                                    response?.ReasonPhrase?.ToString()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error($"ERRO: {ex.Message}");

            }
        }
    }
}
