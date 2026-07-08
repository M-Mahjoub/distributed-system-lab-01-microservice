using Domain.Common;
using System.Xml.Linq;

namespace Domain.Products.Rules
{
    public class ProductMustHaveNameRule : IBusinessRule<Product>
    {
        public Result Check(Product aggregateRoot)
        {
            if (string.IsNullOrWhiteSpace(aggregateRoot.Name))
                return new Result { IsFailure = true, Errors = new[] { "Product should have a name." } };

            return new Result();
        }
    }
}
