using Domain.Common;
using Domain.Enums;
using Domain.Events;
using Domain.ValueObjects;

namespace Domain.Aggregates.Product
{
    public class Product : AggregateRoot
    {
        public Product(string name, string sku, string currency, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name");

            if (string.IsNullOrWhiteSpace(sku))
                throw new ArgumentException("sku");

            if (amount < 0)
                throw new ArgumentException("amount");

            if (string.IsNullOrWhiteSpace(currency))
                throw new ArgumentException("currency");

            Id = Guid.NewGuid();
            Name = name;
            SKU = sku;
            Money = new Money(amount, currency);
            Status = ProductStatus.Draft;
            CreatedAt = DateTime.UtcNow;

            Raise(new ProductCreated());
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public ProductStatus Status { get; private set; }
        public string Category { get; private set; }
        public string SKU { get; private set; }
        public Money Money { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Description { get; private set; }

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
