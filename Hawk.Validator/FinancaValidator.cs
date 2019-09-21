using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class FinancaValidator : AbstractValidator<Financa>
    {
        public FinancaValidator()
        {
            RuleFor(x => x.Lucro)
                .NotEmpty()
                .WithMessage("Informe o lucro obtido com a venda");

            RuleFor(x => x.ValorCusto)
                .NotEmpty()
                .WithMessage("Informe o Valor de custo");

            RuleFor(x => x.ValorVenda)
                .NotEmpty()
                .WithMessage("Informe um Valor de veda");
                
            
        }
    }
}
