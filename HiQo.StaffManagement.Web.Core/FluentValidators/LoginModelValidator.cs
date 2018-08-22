using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Core.FluentValidators
{
    public class LoginModelValidator:AbstractValidator<LogInViewModel>
    {
        public LoginModelValidator()
        {
            RuleFor(model => model.Email).NotEmpty().WithMessage("Field can not be empty").EmailAddress()
                .WithMessage("Email is not valid");
            RuleFor(model => model.Password).NotEmpty().WithMessage("Field can not be empty");
        }
    }
}
