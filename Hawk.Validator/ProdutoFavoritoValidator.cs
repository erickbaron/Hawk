using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class ProdutoFavoritoValidator : AbstractValidator<ProdutoFavorito>
    {
        public ProdutoFavoritoValidator()
        {
            RuleFor(x => x.ProdutoId)
                .NotEmpty()
                .WithMessage("Informe o produto");

        }
    }
}
