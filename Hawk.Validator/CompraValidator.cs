using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class CompraValidator : AbstractValidator<Compra>
    {
        public CompraValidator()
        {
            RuleFor(x => x.ValorTotal)
                .NotEmpty()
                .WithMessage("Informe o valor final da compra");
                        
            }
     }
}
