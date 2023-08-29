using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppBot.Domain.Entities;

namespace WhatsAppBot.Repositories
{
    public class AlertaRepository
    {
        private readonly RepositoryBase _repository;

        public AlertaRepository(RepositoryBase repository)
        {
            _repository = repository;
        }

        public List<Alerta> getMessages()
        {
            using(var conn = _repository.Connection())
            {
                //Ajustar query quando finalizar os testes
                string sql = "SELECT * FROM alerta where tipo = 'api' AND id = '123'";

                return conn.Query<Alerta>(sql).ToList();
            }
        }

        public void UpdateTable(Alerta alerta, string json, string messageId)
        {
            using (var conn = _repository.Connection())
            {
                string sql = @"UPDATE alerta set dataenvio = NOW(),
                               json = @json,
                               MessageId = @MessageId
                               WHERE Id = @Id ";

                conn.Execute(sql, new {Id = alerta.Id, json = json, MessageId = messageId});
            }
        }
    }
}
