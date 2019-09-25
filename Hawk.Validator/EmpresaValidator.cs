using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class EmpresaValidator : AbstractValidator<Empresa>
    {
        public EmpresaValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Informe o nome da empresa")
                .Length(3, 100)
                .WithMessage("O nome deve ter entre 3 e 100 caracteres");

            RuleFor(x => x.Ramo)
                .NotEmpty()
                .WithMessage("Informe o Ramo da empresa")
                .Length(3, 30)
                .WithMessage("O Ramo deve conter entre 3 e 30 caracteres");

            RuleFor(x => x.Telefone)
                .NotEmpty()
                .WithMessage("Informe um telefone")
                .Length(11)
                .WithMessage("Informe um Telefone válido");

            RuleFor(x => x.Cep)
               .NotEmpty()
               .WithMessage("Informe o CEP")
               .Length(8)
               .WithMessage("O CEP deve ter entre 8 caracteres");

            RuleFor(x => x.Cidade)
                .NotEmpty()
                .WithMessage("Informe a cidade")
                .Length(3, 100)
                .WithMessage("Informe uma cidade válida");

            RuleFor(x => x.Estado)
                .NotEmpty()
                .WithMessage("Informe o Estado")
                .Length(3, 100)
                .WithMessage("Informe um Estado válida");

            RuleFor(x => x.Cnpj)
                .NotEmpty()
                .WithMessage("Informe o CNPJ")
               // .Length(14)
                //.WithMessage("Número de caracteres inválido")
                .Must(VerificaCnpj).WithMessage("Este Cnpj não é válido ou o número de caracteres está incorreto");
        }

        private bool VerificaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}
