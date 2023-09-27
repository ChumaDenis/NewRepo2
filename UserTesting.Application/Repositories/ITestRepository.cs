using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.DTOs;
using UserTesting.Domain.Entities;

namespace UserTesting.Application.Repositories
{
    public interface ITestRepository:IBaseRepository<Test>
    {
        Task<Test> CreateTest(Test test, CancellationToken cancellationToken);
        Task<UserTest> SetTestToUser(Guid testId, Guid userId);
        Task<List<TestDTO>> GetByUserId(Guid UserId, CancellationToken cancellationToken);
        Task<Test> GetTestById(Guid TestId, Guid UserId, CancellationToken cancellationToken);
        Task<TestTaskDTO> FinishTheTest(TestTaskDTO test, Guid UserId, CancellationToken cancellationToken); 
    }
}
