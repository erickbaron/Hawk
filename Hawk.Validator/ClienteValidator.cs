using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Informe seu nome ")
                .Length(3, 100)
                .WithMessage("O nome deve ter entre 3 e 100 caracteres");

            RuleFor(x => x.Cpf)
                .NotEmpty()
                .WithMessage("Informe seu CPF ")
                .Length(11)
                .WithMessage("Informe um CPF válido");

            RuleFor(x => x.DataNascimento)
                .NotEmpty()
                .WithMessage("Informe uma Data de Nascimento");

            RuleFor(x => x.Telefone)
                .NotEmpty()
                .WithMessage("Informe seu seu telefone ")
                .Length(10)
                .WithMessage("Informe um Telefone válido");

        }
            
    }
}
