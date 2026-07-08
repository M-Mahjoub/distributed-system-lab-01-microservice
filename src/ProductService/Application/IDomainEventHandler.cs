using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IDomainEventHandler<TEvent>
     where TEvent : DomainEvent
    {
        Task HandleAsync(TEvent domainEvent);
    }
}
