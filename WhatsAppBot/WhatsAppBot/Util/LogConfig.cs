using log4net.Config;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WhatsAppBot.Util
{
    public class LogConfig
    {
        public static void ConfigureLog4net()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());


            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));


            var fileAppender = logRepository.GetAppenders().FirstOrDefault(a => a.Name == "FileAppenderName") as log4net.Appender.RollingFileAppender;

            if (fileAppender != null)
            {

                string logFileName = GetLogFileName();


                fileAppender.File = logFileName;
                fileAppender.ActivateOptions();
            }
        }

        public static string GetLogFileName()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var path = appSettings.Get("Path");

            string logDirectory = path;
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            string logFileName = $"{logDirectory}log_{currentDate}.log";

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            return logFileName;
        }
    }
}
