using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    using core.Domain.Entities;
    using core.Service;

    public interface IAlertaService
    {
        List<alerta> GetFila();
        string InserirMensagem(alertaInsert mensagem, string grupo);
        void UpdateMensagem(string id);
        void UpdateMensagemRecebida(string telefone, DateTime data);
    }
}
