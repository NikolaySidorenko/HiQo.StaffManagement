﻿using System;
using FluentValidation;
using FluentValidation.Results;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Core.FluentValidators
{

    public class UserValidator:AbstractValidator<UpsertUser>
    {
        private readonly IUserRepositiry _repositiry;

        public UserValidator(IUserRepositiry repositiry)
        {
            _repositiry = repositiry;
            RuleFor(user => user.UserId).Must(id=>id>=0).WithMessage("ID must be greater than 0");
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
            RuleFor(user => user.Email).NotEmpty().WithMessage("Field cannot be empty");
            RuleFor(user => user).Must(IsFullNameValid).WithMessage("User with this name already exists");
        }

        private bool IsFullNameValid(UpsertUser user)
        {
            return _repositiry.IsValid(user.FirstName, user.LastName,user.UserId);
        }
       
    }
}
