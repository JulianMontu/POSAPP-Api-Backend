﻿using FluentValidation;
using POS.Aplication.DTOS.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Aplication.Validators.Category
{
    public class CategoryValidator : AbstractValidator<CategoryRequestDTO>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo Nombre no puede ser nulo.")
                .NotEmpty().WithMessage("El campo nombre no puede ser vacio.");
        }
    }
}
