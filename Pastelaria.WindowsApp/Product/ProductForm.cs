using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Product
{
    public partial class ProductForm : Form
    {
        private Color lightRed = Color.FromArgb(255, 105, 97);
        private const long maxSize = 2097152;//2MB

        public Domain.Product product;

        public Domain.Product Product
        {
            get
            {
                return product;
            }
            set
            {
                lblId.Text = product.Id.ToString();
                lblName.Text = product.Name.ToString();
                lblValue.Text = product.Value.ToString();
                lblDescription.Text = product.Description.ToString();
                if(product.Image != null)
                    pctImage.Image = product.Image;
            }
        }

        public ProductForm(string title)
        {
            product = null;
            product = new();
            InitializeComponent();
            this.lblMessages.BackColor = lightRed;
            this.Text = title;
        }

        private void ibtnAlterImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = openFileDialog.FileName;
                var size = new FileInfo(image).Length;
                if(size < maxSize)
                {
                    pctImage.Image = (Bitmap)Image.FromFile(image);
                }
            }
        }
    }
}
