using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationManager = System.Configuration.ConfigurationManager;
namespace WhatsAppBot.Repositories
{
    public class RepositoryBase
    {
        public MySqlConnection Connection()
        {

            var appSettings = ConfigurationManager.AppSettings;
            var MysqlServerConnection = appSettings.Get("MySqlDbConnection");
            MySqlConnection connection = new MySqlConnection(MysqlServerConnection);

            return connection;
        }
    }
}