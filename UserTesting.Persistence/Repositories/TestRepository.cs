using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Common.Exeptions;
using UserTesting.Application.DTOs;
using UserTesting.Application.Repositories;
using UserTesting.Domain.Entities;
using UserTesting.Persistence.Context;

namespace UserTesting.Persistence.Repositories
{

    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(DataContext context) : base(context)
        {
        }


        public async Task<Test> CreateTest(Test test, CancellationToken cancellationToken)
        {
            if (Context.Tests.Any(x => x.Title == test.Title))
                throw new BadRequestException("The test is already in the database.");
            test.Tasks.ForEach(async x =>
            {
                var task= await Context.TestTasks.AddAsync(x);
                task.Entity.AnswerOptions.ForEach(answerOptions => { Context.Answers.Add(answerOptions); });
            });
            await Context.AddAsync(test, cancellationToken);
            return test;
        }

        public Task<TestTaskDTO> FinishTheTest(TestTaskDTO test, Guid UserId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<TestDTO>> GetByUserId(Guid UserId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Test> GetTestById(Guid TestId, Guid UserId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserTest> SetTestToUser(Guid testId, Guid userId)
        {
            throw new NotImplementedException();
        }

        
    }
}
