using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Common.Exeptions;
using UserTesting.Application.Repositories;
using UserTesting.Domain.Entities;
using UserTesting.Persistence.Context;

namespace UserTesting.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            var user = await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);

            if (user == null)
            {
                throw new BadRequestException("This user is not in the database.");
            }
            return user;
        }

        public async Task<User> AddUser(User user, CancellationToken cancellationToken)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            var check= Context.Users.AnyAsync(x => x.Email == user.Email, cancellationToken);
            if (await check)
                throw new BadRequestException(nameof(user));
            Context.Users.Add(user);

            return user;
        }
    }
}
