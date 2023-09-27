using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTesting.Application.Features.UserFeatures.AddUser
{
    public sealed class AddUserValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserValidator()
        {
            RuleFor(x => x.email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.password).NotEmpty().MaximumLength(50);
        }
    }
}
