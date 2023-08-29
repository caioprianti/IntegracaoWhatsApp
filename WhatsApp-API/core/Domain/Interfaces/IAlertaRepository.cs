
namespace core.Domain.Interfaces
{
    using core.Domain.Entities;
    using core.Domain;
    using System.Collections.Generic;
    using System;

    public interface IAlertaRepository
    {
        List<alerta> GetFila();
        List<grupo_alerta_usuario> GetGrupoMensagens(string grupo);
        void InserirMensagem(alertaInsert mensagem, string id);
        void SalvaLog();
        void UpdateMensagem(string id);
        void UpdateMensagemRecebida(string telefone, DateTime data);
    }
}
