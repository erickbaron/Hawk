using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Informe o nome ")
                .Length(3, 100)
                .WithMessage("O nome deve ter entre 3 e 100 caracteres");

            RuleFor(x => x.Descricao)
                .NotEmpty()
                .WithMessage("Informe a Descrição ")
                .Length(10, 1000)
                .WithMessage("Descrição deve ter entre 10 e 1000 caracteres");

            RuleFor(x => x.Altura)
                .NotEmpty()
                .WithMessage("Informe a altura do produto");

            RuleFor(x => x.Largura)
                .NotEmpty()
                .WithMessage("Informe a largura do produto");

            RuleFor(x => x.Comprimento)
                .NotEmpty()
                .WithMessage("Informe o comprimento do produto");

            RuleFor(x => x.Peso)
                .NotEmpty()
                .WithMessage("Informe o peso do produto");

            RuleFor(x => x.ValorCusto)
                .NotEmpty()
                .WithMessage("Informe o Valor de custo ");

            RuleFor(x => x.ValorVenda)
                .NotEmpty()
                .WithMessage("Informe o Valor de venda ");

            RuleFor(x => x.CategoriaId)
                .NotEmpty()
                .WithMessage("Informe a categoria");

        }

    }
}
