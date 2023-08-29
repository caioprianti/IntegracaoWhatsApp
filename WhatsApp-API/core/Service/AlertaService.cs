using System.Collections.Generic;

namespace core.Service
{
    using System;
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Service;

    public class AlertaService : IAlertaService
    {

        private readonly IAlertaRepository _AlertaRepository;

        public AlertaService(IAlertaRepository AlertaRepository)
        {
            _AlertaRepository = AlertaRepository;
        }

        public List<alerta> GetFila()
        {
            _AlertaRepository.SalvaLog();
            var ret = _AlertaRepository.GetFila();

            foreach (var item in ret)
            {
                item.telefone = item.telefone.Replace("+", "");

                if (item.telefone.Substring(0, 2) != "55")
                {
                    item.telefone = "55" + item.telefone;
                }
            }
            return ret;
        }

        public string InserirMensagem(alertaInsert mensagem, string grupo)
        {
            if (!string.IsNullOrEmpty(grupo))
            {
                List<grupo_alerta_usuario> lista = _AlertaRepository.GetGrupoMensagens(grupo);
                foreach (var item in lista)
                {
                    string id = Guid.NewGuid().ToString();
                    mensagem.email = item.Email;
                    mensagem.telefone = item.Telefone;
                    mensagem.nome = item.Nome;
                    _AlertaRepository.InserirMensagem(mensagem, id);
                }
                return "Mensagens inseridas para o grupo com sucesso!";
            }
            else
            {
                string id = Guid.NewGuid().ToString();
                _AlertaRepository.InserirMensagem(mensagem, id);
                return id;
            }           
        }

        public void UpdateMensagem(string id)
        {
            _AlertaRepository.UpdateMensagem(id);
        }

        public void UpdateMensagemRecebida(string telefone, DateTime data)
        {
            telefone = telefone.Replace("+","");
            if (telefone.Substring(0,2) == "55")
            {
                telefone = telefone.Substring(2,telefone.Length-2);
            }
            _AlertaRepository.UpdateMensagemRecebida(telefone, data);
        }
    }
}
