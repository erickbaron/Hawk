using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class AvaliacaoProdutoValidator : AbstractValidator<AvaliacaoProduto>
    {
        public AvaliacaoProdutoValidator()
        {
            RuleFor(x => x.Comentario)
                .NotEmpty()
                .WithMessage("Informe seu Comentário")
                .Length(3, 100)
                .WithMessage("O nome deve ter entre 0 e 1000 caracteres");

            RuleFor(x => x.Nota)
                .NotEmpty()
                .WithMessage("Informe sua nota ");

        }
    }
}
