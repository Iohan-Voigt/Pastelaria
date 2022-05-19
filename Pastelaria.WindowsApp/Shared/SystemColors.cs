using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.Control;

namespace Pastelaria.WindowsApp.Shared
{
    public static class SystemColors
    {
        public static Color BaseColor;
        public static Color SecondColor;
        public static Color ThirdColor;
        public static Color TextColor;

        private static XmlDocument xmlDoc;
        private static XmlNode xmlNode;

        public static void ConfigureColors(this ControlCollection controls)
        {
            xmlDoc = new();
            xmlDoc.Load(@"..\..\..\appsettings.xml");
            xmlNode = xmlDoc.SelectSingleNode(@"appsettings/colors/" + GensSysConfs.Default.ColorTheme);

            string[] splitBaseCollor = xmlNode.SelectSingleNode("baseColor").InnerText.Split(',');
            string[] splitSecondCollor = xmlNode.SelectSingleNode("secondColor").InnerText.Split(',');
            string[] splitThirdCollor = xmlNode.SelectSingleNode("thirdColor").InnerText.Split(',');
            string[] splittextCollor = xmlNode.SelectSingleNode("textColor").InnerText.Split(',');

            BaseColor   = Color.FromArgb(Int32.Parse(splitBaseCollor[0])
                                        ,Int32.Parse(splitBaseCollor[1])
                                        ,Int32.Parse(splitBaseCollor[2]));
            SecondColor = Color.FromArgb(Int32.Parse(splitSecondCollor[0])
                                        ,Int32.Parse(splitSecondCollor[1])
                                        ,Int32.Parse(splitSecondCollor[2]));
            ThirdColor  = Color.FromArgb(Int32.Parse(splitThirdCollor[0])
                                        ,Int32.Parse(splitThirdCollor[1])
                                        ,Int32.Parse(splitThirdCollor[2]));
            TextColor   = Color.FromArgb(Int32.Parse(splittextCollor[0])
                                        ,Int32.Parse(splittextCollor[1])
                                        ,Int32.Parse(splittextCollor[2]));
            UpdateControls(controls);
        }

        public static void UpdateControls(this ControlCollection controls)
        {
            foreach (Control ctr in controls)
            {
                switch (ctr)
                {
                    case Label:
                        ctr.ForeColor = TextColor;
                        break;
                    case Button:
                        ctr.BackColor = SecondColor;
                        ctr.ForeColor = TextColor;
                        break;
                    case Panel:
                        ctr.BackColor = ThirdColor;
                        break;
                    case ToolStrip:
                        ctr.BackColor = ThirdColor;
                        break;

                }     
            }
            controls.Owner.BackColor = ThirdColor;
        }
    }
}
