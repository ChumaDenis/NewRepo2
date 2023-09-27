using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Features.UserFeatures.GetByEmail;

namespace UserTesting.Application.Features.UserFeatures.AddUser
{
    public sealed record AddUserRequest(string email, string password) : IRequest<AddUserResponse>;
}
