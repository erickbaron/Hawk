using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Hawk.Validator
{
    public class CategoriaValidator: AbstractValidator<Categoria>
    {
        Categoria categoria = new Categoria();
        CustomerValidator validator = new CustomerValidator();

        ValidationResult result = validator.Validate(categoria);

        public CategoriaValidator()
        {
            RuleFor(categoria => categoria.Nome).NotNull();
        }
    }
}

