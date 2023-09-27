using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.Features.UserFeatures.GetByEmail
{
    public sealed class GetByEmailMapper : Profile
    {
        public GetByEmailMapper()
        {
            CreateMap<GetByEmailRequest, User>();
            CreateMap<User, GetByEmailResponse>();
        }
    }
}
