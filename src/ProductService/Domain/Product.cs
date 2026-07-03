using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public Product(string name, string sku, string currency)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            if (string.IsNullOrEmpty(sku))
                throw new ArgumentNullException("sku");

            if (string.IsNullOrEmpty(currency))
                throw new ArgumentNullException("currency");

            this.Id = Guid.NewGuid();
            this.Name = name;
            this.SKU = sku;
            this.Currency = currency;
            this.Status = 0;
            this.CreateAt = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public string Name { get; private set; }
        public ProductStatus Status { get; private set; }
        public string Category { get; private set; }
        public string SKU { get; private set; }
        public decimal Price { get; private set; }
        public string Currency { get; private set; }
        public DateTime CreateAt { get; private set; }
        public string Description { get; private set; }

        public void Rename(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            this.Name = name;
        }
    }
}
