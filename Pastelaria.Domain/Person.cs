using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain
{
    public abstract class Person : EntityBase
    {
    
        public string Name { get; set; }
        #nullable enable
        public string? IndentityDocument { get; set; }
        
        public string? PhoneNumber {get;set;}



        public virtual string ValidatePerson() 
        {
            string validationResult = "";

            if(!ValidateCpf(IndentityDocument))
                validationResult = "The Indetity Document isn't right\n";

            if (Name.Length < 5)
                validationResult += "The name must have at least 5 characters\n";


            return validationResult;
        }

        private static bool ValidateCpf(string strCpf)
        {
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			strCpf = strCpf.Trim();
			strCpf = strCpf.Replace(".", "").Replace("-", "");
			if (strCpf == "00000000000" || strCpf == "11111111111" || strCpf == "22222222222" ||
			strCpf == "33333333333" || strCpf == "44444444444" || strCpf == "55555555555" ||
			strCpf == "66666666666" || strCpf == "77777777777" || strCpf == "88888888888" ||
			strCpf == "99999999999")
				return false;
			if (strCpf.Length != 11)
				return false;
			tempCpf = strCpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return strCpf.EndsWith(digito);
		}

    }
}
