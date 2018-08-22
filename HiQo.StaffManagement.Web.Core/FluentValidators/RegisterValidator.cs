using FluentValidation;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Core.FluentValidators
{
    public class RegisterValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
            RuleFor(model => model.Email).NotEmpty().WithMessage("Email can not be empty").EmailAddress()
                .WithMessage("Email must be valid");
            RuleFor(model => model.Password).NotEmpty().WithMessage("Password can not be empty");
            RuleFor(model => model.ConfirmPassword).NotEmpty().WithMessage("Feild can not be empty");
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("Field cannot be empty")
                .Length(1, 25).WithMessage("The length of the line should be in the range from 1 to 25")
                .Matches(@"^[\p{L} \.\-]+$").WithMessage("The name must contain only letters");
            RuleFor(user => user.LastName).NotEmpty().WithMessage("Field cannot be empty")
                .Length(1, 25).WithMessage("The length of the line should be in the range from 1 to 25")
                .Matches(@"^[\p{L} \.\-]+$").WithMessage("The name must contain only letters");
            RuleFor(user => user.UserName).NotEmpty().WithMessage("Field cannot be empty")
                .Length(1, 25).WithMessage("The length of the line should be in the range from 1 to 25")
                .Matches(@"^[\p{L} \.\-]+$").WithMessage("The name must contain only letters");
            RuleFor(user => user.DateOfBirth).NotEmpty().WithMessage("Field cannot be empty");
            RuleFor(model => model).Must(IsPasswordsValid).WithMessage("Passwords must be equale");
        }

        private bool IsPasswordsValid(RegisterViewModel model)
        {
            return model.ConfirmPassword.Equals(model.Password);
        }
    }
}