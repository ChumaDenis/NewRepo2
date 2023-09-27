using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Features.UserFeatures.AddUser;

namespace UserTesting.Application.Features.TestFeatures.CreateTest
{
    
    public sealed class CreateTestValidator : AbstractValidator<CreateTestRequest>
    {
        public CreateTestValidator()
        {
        //RuleFor(x => x.test).NotEmpty();
        //RuleFor(x=>x.test.Tasks).NotEmpty();
        //RuleFor(x => x.test.Title).NotEmpty();
        }
    }
}
