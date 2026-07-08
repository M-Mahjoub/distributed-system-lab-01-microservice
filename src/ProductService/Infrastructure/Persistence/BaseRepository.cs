using Application.Abstractions;
using Domain.Common;

namespace Infrastructure.Persistence
{
    public class BaseRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : AggregateRoot<TId>
    {
        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
