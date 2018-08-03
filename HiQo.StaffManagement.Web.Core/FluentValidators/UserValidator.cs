using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HiQo.StaffManagement.Web.Core.Models;


namespace HiQo.StaffManagement.Web.Core.FluentValidators
{
    public class UserValidator:AbstractValidator<CreateEditUser>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty().Length(1, 25).Matches(@"^[a-zA-Z]+$").WithMessage("Some message");
            RuleFor(user => user.LastName).NotEmpty().Length(1,25).Matches(@"^[a-zA-Z]+$").WithMessage("Some message");
            RuleFor(user => user.UserName).NotEmpty().Length(1, 25).Matches(@"^[a-zA-Z]+$").WithMessage("Some message");
            RuleFor(user => user.DateOfBirth).NotEmpty().WithMessage("Some message");
            RuleFor(user => user.DepartmentId).GreaterThan(0).NotEmpty().WithMessage("Some message");
            RuleFor(user => user.CategoryId).GreaterThan(0).NotEmpty().WithMessage("Some message");
            RuleFor(user => user.PositionId).GreaterThan(0).NotEmpty().WithMessage("Some message");
            RuleFor(user => user.GradeId).GreaterThan(0).NotEmpty().WithMessage("Some message");
            RuleFor(user => user.RoleId).GreaterThan(0).NotEmpty().WithMessage("Some message");

        }
    }
}
