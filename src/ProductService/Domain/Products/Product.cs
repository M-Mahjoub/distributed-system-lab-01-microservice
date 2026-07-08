using Domain.Common;
using Domain.Products.Events;
using Domain.Products.Rules;
using Domain.Products.ValueObjects;
using System.Data;

namespace Domain.Products
{
    public class Product : AggregateRoot<ProductId>
    {
        private Product()
        {

        }
        public Product(string name, string sku, string currency, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name cannot be empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(sku))
                throw new ArgumentException("sku");

            if (amount < 0)
                throw new ArgumentException("amount");

            if (string.IsNullOrWhiteSpace(currency))
                throw new ArgumentException("currency");

            Id = ProductId.New();
            Name = name;
            Sku = new Sku("PRD-000");
            Money = new Money(amount, currency);
            Status = ProductStatus.Draft;
            CreatedAt = DateTime.UtcNow;

            Raise(new ProductCreated());
        }

        public string Name { get; private set; }
        public ProductStatus Status { get; private set; }
        public string Category { get; private set; }
        public Sku Sku { get; private set; }
        public Money Money { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Description { get; private set; }
        private readonly List<string> _images = new();

        public IReadOnlyCollection<string> Images
            => _images.AsReadOnly();

        public Result Publish()
        {
            var rules = new IBusinessRule<Product>[]
                                             {
                                                 new ProductMustHaveImageRule(),
                                                 new ProductMustHaveNameRule(),
                                                 new ProductMustHavePriceRule(),
                                                 new ProductMustHaveSkuRule(),
                                             };

            foreach (var rule in rules)
            {
                var result = rule.Check(this);

                if (result.IsFailure)
                    return result;
            }

            Status = ProductStatus.Published;

            Raise(new ProductPublished(this.Id));

            return new Result();
        }

        public void Rename(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name");

            Name = name;
        }

        public void ChangePrice(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException();

            var money1 = Money;
            Money = money1 with { Amount = amount };
        }

        public void AsignCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("category");

            Category = category;
        }

        public void UpdateDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("description");

            Description = description;
        }
    }
}
