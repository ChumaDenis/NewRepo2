using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Features.UserFeatures.AddUser;
using UserTesting.Application.Repositories;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.Features.TestFeatures.CreateTest
{
    public sealed class CreateTestHandler : IRequestHandler<CreateTestRequest, CreateTestResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITestRepository _testRepository;
        private readonly IMapper _mapper;

        public CreateTestHandler(IUnitOfWork unitOfWork, ITestRepository testRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _testRepository = testRepository;
            _mapper = mapper;
        }

        public async Task<CreateTestResponse> Handle(CreateTestRequest request, CancellationToken cancellationToken)
        {
            var test = _mapper.Map<Test>(request);
            _testRepository.Create(test);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateTestResponse>(test);
        }
    }
}

