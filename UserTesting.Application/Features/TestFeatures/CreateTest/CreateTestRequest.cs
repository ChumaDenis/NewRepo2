using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Features.UserFeatures.AddUser;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.Features.TestFeatures.CreateTest
{
    public sealed record CreateTestRequest(Test test, CancellationToken CancellationToken) : IRequest<CreateTestResponse>;
}
