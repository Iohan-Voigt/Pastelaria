using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public class PictureBoxWithProduct : PictureBox
    {
        public Domain.Product Product { get; set; }
    }
}
