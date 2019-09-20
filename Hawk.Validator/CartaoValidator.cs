using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class CartaoValidator : AbstractValidator<Cartao>
    {
        public CartaoValidator()
        {
            RuleFor(x => x.NomeProprietario)
                .NotEmpty()
                .WithMessage("Informe o nome do proprietario ")
                .Length(3, 100)
                .WithMessage("O nome deve ter entre 3 e 100 caracteres");

            RuleFor(x => x.Cvc)
                .NotEmpty()
                .WithMessage("Informe o CVC do cartao")
                .Length(3)
                .WithMessage("Informe um CVC válido");
                
            RuleFor(x => x.DataVencimento)
                .NotEmpty()
                .WithMessage("Informe uma Data de Vencimento");

            RuleFor(x => x.Numero)
                .NotEmpty()
                .WithMessage("Informe o numero do cartão")
                .CreditCard()
                .WithMessage("Informe um cartão válido");

        }
    }
}
