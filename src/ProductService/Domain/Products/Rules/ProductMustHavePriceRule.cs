using Domain.Common;
using Domain.Products.ValueObjects;

namespace Domain.Products.Rules
{
    public class ProductMustHavePriceRule : IBusinessRule<Product>
    {
        public Result Check(Product aggregateRoot)
        {
            if (aggregateRoot.Money == null || aggregateRoot.Money.Amount == 0)
                return new Result { IsFailure = true, Errors = new[] { "Product needs to price." } };

            return new Result();
        }
    }
}