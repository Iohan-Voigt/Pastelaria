using Microsoft.EntityFrameworkCore;
using Pastelaria.ORM;
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            LoginForm loginForm = new ();
            MainFrameForm main = new();

            PastelariaDBContext db = new();
            var pendingChanges = db.Database.GetPendingMigrations();
            if (pendingChanges.Any())
                db.Database.Migrate();


            Application.Run(main);
        }
    }
}
