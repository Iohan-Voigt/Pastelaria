using Microsoft.EntityFrameworkCore;
using Pastelaria.ORM;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Costumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {

            
            GeneralConfig.Language = GensSysConfs.Default.Language;
            GeneralConfig.SetLanguageData();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            LoginForm loginForm = new ();

            PastelariaDBContext db = new();
            var pendingChanges = db.Database.GetPendingMigrations();
            if (pendingChanges.Any())
                db.Database.Migrate();


            Application.Run(loginForm);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
