﻿using Pastelaria.Domain.Shared;
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
            bool documentTypeValidationResult;


            if (IndentityDocument.Length == 11)
                documentTypeValidationResult = ValidateCpf(IndentityDocument);
            else
                validationResult = "The DocumentType isn't right\n";

            if (Name.Length < 5)
                validationResult += "The name cannot be null or less than 5 characters";


            if (validationResult == "")
                validationResult = "VALID";
            return validationResult;
        }

        private static bool ValidateCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf[..9];
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cpf.EndsWith(digito);
        }

    }
}
