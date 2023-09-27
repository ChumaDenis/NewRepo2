using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Domain.Entities;

namespace UserTesting.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TestTask> TestTasks { get; set; }
        public DbSet<AnswerOption> Answers { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<UserTest> UserTest { get; set; }
    }
}
