using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Shared
{
    public class CustomEvents
    {
        public static void EnterFieldEvent(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.LightGoldenrodYellow;
            }
                
        }

        public static void LeaveFieldEvent(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt)
                txt.BackColor = Color.White;
        }
    }
}
