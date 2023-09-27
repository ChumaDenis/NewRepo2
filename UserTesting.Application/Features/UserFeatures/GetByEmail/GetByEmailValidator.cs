using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTesting.Application.Features.UserFeatures.GetByEmail
{
    public sealed class GetByEmailValidator : AbstractValidator<GetByEmailRequest>
    {
        public GetByEmailValidator()
        {
            RuleFor(x => x.email).NotEmpty().MaximumLength(50);
        }
    }
}
