namespace Domain.Common
{
    public interface IDomainEvent
    {
        public Guid EventId { get; }

        public DateTime OccurredOnUtc { get; }
    }
}
