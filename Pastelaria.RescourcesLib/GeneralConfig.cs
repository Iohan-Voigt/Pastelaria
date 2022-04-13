﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.RescourcesLib
{
    public static class GeneralConfig
    {
        public static string Language;

        //public static Dictionary<string, Color> Settings;

        public static Dictionary<string, string> Data = new Dictionary<string, string>()
        {
            {"Employees",""}
            ,{"Employee",""}
            ,{"Login",""}
            ,{"Password",""}
            ,{"User",""}
            ,{"Users",""}
            ,{"Configuration",""}
            ,{"Language",""}
            ,{"Save",""}
            ,{"Cancel",""}
            ,{@"AreYouSureThatYouWantToCancel?",""}
            ,{"Home",""}//
            ,{"Products",""}
            ,{"Product",""}
            ,{"Customers",""}
            ,{"Customer",""}
            ,{"Sells",""}
            ,{"Sell",""}
            ,{"Orders",""}
            ,{"Order",""}
            ,{"Debits",""}
            ,{"Debit",""}
            ,{"Welcome",""}
            ,{"Name",""}
            ,{"Identify Document",""}
            ,{"Phone Number",""}
            ,{"Registration",""}
            ,{"Acess user",""}
            ,{"Permissions",""}
            ,{"Admin",""}
            ,{"Cashier",""}
            ,{"Add new",""}
            ,{"Register",""}
            ,{"Update",""}
            ,{"Remove",""}
            ,{"Are you sure that you want to remove",""}
            //,{"",""}
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

        public static bool LanguageIsValid()
        {
            foreach (var line in Data)
            {
                if(line.Value.Equals(string.Empty))
                    return false;
            }
            return true;
        }

    }
}