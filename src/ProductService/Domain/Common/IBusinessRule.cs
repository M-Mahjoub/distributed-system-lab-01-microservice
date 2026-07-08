namespace Domain.Common
{
    public interface IBusinessRule<TAggregateRoot> where TAggregateRoot : class
    {
        public Result Check(TAggregateRoot aggregateRoot);
    }
}
