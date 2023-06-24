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
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(u => u.FullName).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(u => u.Username).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(e => e.Email).NotNull().NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(u => u.Password).Length(5, 12).Must(u => PasswordExtentions.HasValidPassword(u));
            RuleFor(u => u.RepeatPassword).Equal(u => u.Password);

        }
    }
}
