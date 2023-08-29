using core.Domain.Entities;
using core.Domain.Interfaces;
using Dapper;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;

namespace core.Infra.Repository
{
    public class WebHookRepository
    {
        private readonly IRepositoryBase _RepositoryBase;


        public WebHookRepository(IRepositoryBase Repository)
        {
            _RepositoryBase = Repository;
        }
        public void InsertMessage(WebHook objeto)
        {
            using (var conn = _RepositoryBase.connMysql())
            {

                string sql = @"INSERT INTO WebHook (objeto, entry_id, change_field, messaging_product, display_phone_number,
                            phone_number_id, contact_name, wa_id, message_from, message_id, message_timestamp, message_body, message_type)
                            VALUES (@objeto, @entry_id, @change_field, @messaging_product, @display_phone_number, @phone_number_id, @contact_name, @wa_id, @message_from, @message_id, @message_timestamp, @message_body, @message_type)";

                conn.Execute(sql, new
                {
                    @objeto = objeto.@object,
                    @entry_id = objeto.Entry[0].id,
                    @change_field = objeto.Entry[0].changes[0].field,
                    @messaging_product = objeto.Entry[0].changes[0].value.messaging_product,
                    @display_phone_number = objeto.Entry[0].changes[0].value.metadata.display_phone_number,
                    @phone_number_id = objeto.Entry[0].changes[0].value.metadata.phone_number_id,
                    @contact_name = objeto.Entry[0].changes[0].value.contacts[0].profile.name,
                    @wa_id = objeto.Entry[0].changes[0].value.contacts[0].wa_id,
                    @message_from = objeto.Entry[0].changes[0].value.messages[0].from,
                    @message_id = objeto.Entry[0].changes[0].value.messages[0].id,
                    @message_timestamp = objeto.Entry[0].changes[0].value.messages[0].timestamp,
                    @message_body = objeto.Entry[0].changes[0].value.messages[0].text.body,
                    @message_type = objeto.Entry[0].changes[0].value.messages[0].type

                });
            }
        }
    }
}
