using Domain.Common;

namespace Application.Abstractions
{
    public interface IRepository<TEntity, TId>
        where TEntity : AggregateRoot<TId>
    {

        Task AddAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(Guid id);
    }
}
