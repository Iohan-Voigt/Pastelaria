using System.Drawing;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class OrderPadForm : Form
    {
        private Color lightRed = Color.FromArgb(255, 105, 97);

        private Domain.OrderPad orderpad;
        public Domain.OrderPad OrderPad
        {
            get { return orderpad; }
            set 
            { 
                orderpad = value;

            }
        }

        public OrderPadForm(string title,bool isEdit)
        {
            InitializeComponent();
        }
    }
}
