﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTesting.Application.Repositories;
using UserTesting.Domain.Common;
using UserTesting.Persistence.Context;

namespace UserTesting.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DataContext Context;

        public BaseRepository(DataContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            Context.Add(entity);
        }

        public void Update(T entity)
        {
            Context.Update(entity);
        }

        public void Delete(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }

        public Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return Context.Set<T>().ToListAsync(cancellationToken);
        }
    }
}
