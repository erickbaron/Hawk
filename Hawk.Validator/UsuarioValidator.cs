using FluentValidation;
using Hawk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Validator
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Informe seu nome ")
                .Length(3, 100)
                .WithMessage("O nome deve ter entre 3 e 100 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Informe seu email ")
                .EmailAddress()
                .WithMessage("Informe um email válido");

            RuleFor(x => x.PasswordHash)
                .NotEmpty()
                .WithMessage("Informe uma senha")
                .Length(6, 18)
                .WithMessage("Senha deve conter entre 6 e 18 caracteres");

        }
    }
}
