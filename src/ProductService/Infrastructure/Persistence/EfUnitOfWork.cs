using Application.Abstractions;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly ProductDbContext _dbContext;
        private IDbContextTransaction _transaction;

        public EfUnitOfWork(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task CommitAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
