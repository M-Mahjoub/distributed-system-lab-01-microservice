namespace Domain.Common
{
    public class Entity<TId>
    {
        public TId Id { get; protected set; } = default!;

    }
}
