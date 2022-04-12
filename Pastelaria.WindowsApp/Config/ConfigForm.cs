using Pastelaria.RescourcesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Config
{
    public partial class ConfigForm : Form
    {
        private List<string> Languages = new()
        {
            "en-EN",
            "pt-BR",
            "es-ES"
        };

        public ConfigForm()
        {
            InitializeComponent();
            ConfigureComboBoxLanguage();
            ConfigureTexts();
        }

        private void ConfigureComboBoxLanguage()
        {
            comboBoxLanguages.DataSource = Languages;
            comboBoxLanguages.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigureTexts() 
        {
            iconButtonCancel.Text = GeneralConfig.Data["Cancel"];
            iconButtonSave.Text = GeneralConfig.Data["Save"];
            labelLanguage.Text = GeneralConfig.Data["Language"];
            labelTitle.Text = GeneralConfig.Data["Configuration"];
            this.Text = GeneralConfig.Data["Configuration"];
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            GensSysConfs.Default.Language = comboBoxLanguages.SelectedItem.ToString();
            GensSysConfs.Default.Save();
            GeneralConfig.Language = GensSysConfs.Default.Language;
            GeneralConfig.SetLanguageData();

            if (!GeneralConfig.LanguageIsValid())
            {
                GensSysConfs.Default.Language = "en-EN";
                GeneralConfig.Language = GensSysConfs.Default.Language;
                GeneralConfig.SetLanguageData();
                MessageBox.Show("Error on translating texts, restoring to default (en-EN).\nPlease contact support");
            }
            ConfigureTexts();
            this.Close();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GeneralConfig.Data[@"AreYouSureThatYouWantToCancel?"],"", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }
    }
}
