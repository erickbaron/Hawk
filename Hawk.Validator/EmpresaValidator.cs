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
                .WithMessage("Informe um Ramo válido");

            RuleFor(x => x.Telefone)
                .NotEmpty()
                .WithMessage("Informe um telefone")
                .Length(11)
                .WithMessage("Informe um Telefone válido");

            RuleFor(x => x.Cnpj)
                .NotEmpty()
                .WithMessage("Informe o CNPJ")
                .Length(14)
                .WithMessage("Informe um CNPJ válido");
        }
    }
}
