using System.Collections.Generic;

namespace core.Infra.Repository
{
    using System;
    using Dapper;
    using core.Domain;
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Infra.Repository;
    using System.Linq;
    using core.Util;
    using DocumentFormat.OpenXml.InkML;
    using DocumentFormat.OpenXml.Office2010.Excel;

    public class AlertaRepository : IAlertaRepository
    {

        private readonly IRepositoryBase _RepositoryBase;
        public AlertaRepository(IRepositoryBase Repository)
        {
            _RepositoryBase = Repository;
        }

        public List<alerta> GetFila()
        {
            var conn = _RepositoryBase.connMysql();
            var sql = $@"select * from alerta where dataenvio is null or dataenvio ='0001-01-01' and Tipo = 'bot'";

            return conn.Query<alerta>(sql).ToList();
        }

        public List<grupo_alerta_usuario> GetGrupoMensagens(string grupo)
        {
            var conn = _RepositoryBase.connMysql();
            var sql = $@"SELECT gu.Id, gu.Nome, gu.Telefone, gu.Email FROM grupo_alerta ga inner join grupo_alerta_integrantes gi on ga.Id = gi.IdGrupoAlerta inner join grupo_alerta_usuario gu on gi.IdUsuarioGrupo = gu.Id where ga.Id = '{grupo}';";

            return conn.Query<grupo_alerta_usuario>(sql).ToList();
        }

        public void InserirMensagem(alertaInsert mensagem, string id)
        {
            var conn = _RepositoryBase.connMysql();            
            var sql = $@"INSERT INTO alerta
                                    (Id,
                                    canal,
                                    acao,
                                    mensagem,
                                    tipo,
                                    nome,
                                    email,
                                    telefone)
                                    VALUES
                                    ('{id}',
                                    '{mensagem.canal}',
                                    '{mensagem.acao}',
                                    '{mensagem.mensagem}',
                                    '{mensagem.tipo}',
                                    '{mensagem.nome}',
                                    '{mensagem.email}',
                                    '{mensagem.telefone}');";

            conn.Execute(sql);
        }

        public void SalvaLog()
        {
            var conn = _RepositoryBase.connMysql();
            var sql = $@"INSERT INTO log_alerta
                                    (Id,
                                    Data)
                                    VALUES
                                    ('{Guid.NewGuid().ToString()}',
                                    '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";

            conn.Execute(sql);
        }

        public void UpdateMensagem(string id)
        {
            var conn = _RepositoryBase.connMysql();
            var sql = $@"update alerta set dataenvio = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' where Id='{id}';";
            conn.Execute(sql);
        }

        public void UpdateMensagemRecebida(string telefone, DateTime data)
        {
            var conn = _RepositoryBase.connMysql();
            var sql = $@"update alerta set dataconfirmacao = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' where telefone like '%{telefone}%' and dataenvio < '{data.ToString("yyyy-MM-dd HH:mm:ss")}' and Tipo = 'bot';";
            conn.Execute(sql);
        }
    }
}
