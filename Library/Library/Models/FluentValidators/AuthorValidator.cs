using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.FluentValidators
{
    public class AuthorValidator:AbstractValidator<Tbl_Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Zorunlu alan !");
            When(x => x.FirstName == "Deneme", () =>
                 {
                     RuleFor(x => x.LastName).Must(y => y == "Test").WithMessage("İsim Deneme ise Soyisim Test Olmalı");
                 });
        }
    }
}
