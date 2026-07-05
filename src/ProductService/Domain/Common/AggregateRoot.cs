using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AggregateRoot : Entity
    {
        private readonly List<IDomainEvent> _events = new();
        public void Raise(IDomainEvent domainEvent)
        {
            _events.Add(domainEvent);
        }

        public IReadOnlyCollection<IDomainEvent> DomainEvents
        => _events.AsReadOnly();


        public void ClearDomainEvents()
        {
            _events.Clear();
        }
    }
}
