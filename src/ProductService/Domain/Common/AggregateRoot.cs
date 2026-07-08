namespace Domain.Common
{
    public abstract class AggregateRoot<TId> : Entity<TId>
    {
        private readonly List<DomainEvent> _events = new();
        public void Raise(DomainEvent domainEvent)
        {
            _events.Add(domainEvent);
        }

        public IReadOnlyCollection<DomainEvent> DomainEvents
        => _events.AsReadOnly();


        internal void ClearDomainEvents()
        {
            _events.Clear();
        }
    }
}
