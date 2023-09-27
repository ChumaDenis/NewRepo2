using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Features.UserFeatures.GetByEmail;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.Features.UserFeatures.AddUser
{
    public sealed class AddUserMapper : Profile
    {
        public AddUserMapper()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User, AddUserResponse>();
        }
    }
}
