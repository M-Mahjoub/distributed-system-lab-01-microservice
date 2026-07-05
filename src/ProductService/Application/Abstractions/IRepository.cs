using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IRepository<TEntity>
        where TEntity : AggregateRoot
    {

        Task AddAsync(TEntity entity);
    }
}
