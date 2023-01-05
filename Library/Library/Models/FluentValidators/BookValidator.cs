using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.FluentValidators
{
    public class BookValidator:AbstractValidator<Tbl_Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Zorunlu Alan!");
        }
    }
}
