using Domain.Enums;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public Product(string name, string sku, string currency, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name");

            if (string.IsNullOrWhiteSpace(sku))
                throw new ArgumentException("sku");

            if (price < 0)
                throw new ArgumentException("price");

            if (string.IsNullOrWhiteSpace(currency))
                throw new ArgumentException("currency");

            this.Id = Guid.NewGuid();
            this.Name = name;
            this.SKU = sku;
            this.Money = new Money { Amount = price, Currency = currency };
            this.Status = ProductStatus.Draft;
            this.CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public ProductStatus Status { get; private set; }
        public string Category { get; private set; }
        public string SKU { get; private set; }
        public Money Money { get; set; }
        public DateTime CreatedAt { get; private set; }
        public string Description { get; set; }

        public void Rename(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name");

            this.Name = name;
        }

        public void SetPrice(decimal price)
        {
            if (price < 0)
                throw new ArgumentException();

            this.Money.Amount = price;
        }
    }
}
