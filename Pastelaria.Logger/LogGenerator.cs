using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.File;
using System.IO;

namespace Pastelaria.Logger
{
    public abstract class LogGenerator
    {
        const string logsPath = "C:/Pastelaria/Logs/";
        const string logsFile = "Logs.txt";
        public static void ConfigureLog()
        {
            VerifyPathAndFile();
            var logger = new LoggerConfiguration()
                .WriteTo.File(logsPath + logsFile)
                .CreateLogger();
            
            Log.Logger = logger;
        }

        private static void VerifyPathAndFile()
        {
            if (!Directory.Exists(logsPath))
                Directory.CreateDirectory(logsPath);
            if (!File.Exists(logsPath + logsFile))
                File.Create(logsPath + logsFile);
        }
    }
}
