using Domain.Common;
using Domain.Products.ValueObjects;

namespace Domain.Products.Rules
{
    public class ProductMustHaveSkuRule : IBusinessRule<Product>
    {
        public Result Check(Product aggregateRoot)
        {
            if (aggregateRoot.Sku == null || string.IsNullOrWhiteSpace(aggregateRoot.Sku.Value))
                return new Result { IsFailure = true, Errors = new[] { "Product needs to price." } };

            return new Result();
        }
    }
}