using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.RescourcesLib
{
    public static class GeneralConfig
    {
        public static string Language; //{ get { return Language; } set { Language = value; SetLanguageData(); } }

        public static Dictionary<string, string> Data = new Dictionary<string, string>()
        {
            {"Employees",""}
            ,{"Enployee",""}
            ,{"Login",""}
            ,{"Password",""}
            ,{"User",""}
            ,{"Users",""}
        };

        public static void SetLanguageData()
        {
            switch (Language)
            {
                case "en-EN":
                    foreach (var key in Data)
                    {
                        Data[key.Key] = LanguagePack_en_EN.ResourceManager.GetString(key.Key,LanguagePack_en_EN.resourceCulture);
                    }
                    break;
                case "pt-BR":
                    foreach (var key in Data)
                    {
                        Data[key.Key] = LanguagePack_pt_BR.ResourceManager.GetString(key.Key, LanguagePack_pt_BR.resourceCulture);
                    }
                    break;
                case "es-ES":
                    foreach (var key in Data)
                    {
                        Data[key.Key] = LanguagePack_pt_ES.ResourceManager.GetString(key.Key, LanguagePack_pt_ES.resourceCulture);
                    }
                    break;
            }
        }

    }
}
