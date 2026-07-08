using Domain.Common;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Products.Rules
{
    public class ProductMustHaveImageRule : IBusinessRule<Product>
    {
        public Result Check(Product aggregateRoot)
        {
            if (!aggregateRoot.Images.Any())
                return new Result { IsFailure = true, Errors = new[] { "Product should have at least one image." } };

            return new Result();
        }
    }
}