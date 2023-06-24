using FluentValidation;
using ServiceLayer.DTOs.Account;
using ServiceLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validations.Account
{
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(e => e.Email).NotNull().NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(u => u.Password).Length(5, 12).Must(u => PasswordExtentions.HasValidPassword(u));
             
        }

    }
}

