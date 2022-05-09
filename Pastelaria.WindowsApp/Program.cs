using Microsoft.EntityFrameworkCore;
using Pastelaria.ORM;
using Pastelaria.RescourcesLib;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

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

