﻿using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class AvaliacaoEmpresaValidator : AbstractValidator<AvaliacaoEmpresa>
    {
        public AvaliacaoEmpresaValidator()
        {
            RuleFor(x => x.Comentario)
                .NotEmpty()
                .WithMessage("Informe seu Comentário")
                .Length(3, 1000)
                .WithMessage("O comentário deve ter entre 0 e 1000 caracteres");

            RuleFor(x => x.Nota)
                .NotEmpty()
                .WithMessage("Informe sua nota ");

        }
    }
}