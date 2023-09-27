using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Repositories;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.Features.UserFeatures.GetByEmail
{
    public sealed class GetByEmailHandler : IRequestHandler<GetByEmailRequest, GetByEmailResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetByEmailHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetByEmailResponse> Handle(GetByEmailRequest request, CancellationToken cancellationToken)
        {
            var user= await _userRepository.GetByEmail(request.email, cancellationToken);
            return _mapper.Map<GetByEmailResponse>(user);
        }
    }
}
