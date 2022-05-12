using Microsoft.EntityFrameworkCore;
using Pastelaria.Logger;
using Pastelaria.ORM;
using Pastelaria.RescourcesLib;
using Serilog;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Pastelaria.WindowsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            LogGenerator.ConfigureLog();
            Log.Logger.Information($"Boot Started");

            GeneralConfig.Language = GensSysConfs.Default.Language;
            GeneralConfig.SetLanguageData();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new();

            PastelariaDBContext db = new();

            #if DEBUG
            var pendingChanges = db.Database.GetPendingMigrations();
            if (pendingChanges.Any())
                db.Database.Migrate();
            #endif

            Application.Run(loginForm);
        }
    }
}

