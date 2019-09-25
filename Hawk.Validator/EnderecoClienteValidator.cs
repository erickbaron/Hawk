using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class EnderecoClienteValidator : AbstractValidator<EnderecoCliente>
    {
        public EnderecoClienteValidator()
        {
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
                .WithMessage("Informe um Estado válido");
            
        }
    }
}
