using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAsync(
         IReadOnlyCollection<IDomainEvent> domainEvents,
         CancellationToken cancellationToken = default);
    }
}
