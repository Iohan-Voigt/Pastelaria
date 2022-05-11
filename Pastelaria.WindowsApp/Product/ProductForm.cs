using Pastelaria.WindowsApp.Shared;
using System;
using System.Drawing;
using System.IO;
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
            ConfigureTextBox();
        }

        private void ConfigureTextBox()
        {
            txtName.Enter += new(CustomEvents.EnterFieldEvent!);
            txtName.Leave += new(CustomEvents.LeaveFieldEvent!);
            
            txtDescription.Enter += new(CustomEvents.EnterFieldEvent!);
            txtDescription.Leave += new(CustomEvents.LeaveFieldEvent!);

            mtxtValue.Enter += new(CustomEvents.EnterFieldEvent!);
            mtxtValue.Leave += new(CustomEvents.LeaveFieldEvent!);

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

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            product.Name = txtName.Text;
            product.Description = txtDescription.Text;
            product.Image = (Bitmap)pctImage.Image;

            if (mtxtValue.Text != "")
                product.Value = Decimal.Parse(mtxtValue.Text);

            
            string validateResult = product.Validate();
            
            if (validateResult != "VALID")
            {
                lblMessages.Text = new StringReader(validateResult).ReadLine();
                return;
            
            }
            DialogResult = DialogResult.OK;
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
