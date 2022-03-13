using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class OrderPadUserControl : UserControl
    {
        public OrderPadUserControl()
        {
            InitializeComponent();
            orderPadGrid.ConfigColoredGrid();
            orderPadGrid.ConfigJustReadGrid();
            orderPadGrid.Columns.AddRange(ObtainColuns());
        }

        private static DataGridViewColumn[] ObtainColuns()
        {
            var coluns = new DataGridViewColumn[]
               {

               };
            return coluns;
        }
    }
}
