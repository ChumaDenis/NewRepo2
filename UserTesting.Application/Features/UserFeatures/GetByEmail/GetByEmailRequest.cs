using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTesting.Application.Features.UserFeatures.GetByEmail
{
    public sealed record GetByEmailRequest(string email) : IRequest<GetByEmailResponse>;
}
