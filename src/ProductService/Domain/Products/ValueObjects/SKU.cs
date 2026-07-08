using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products.ValueObjects
{
    public sealed record Sku
    {
        public string Value { get; }

        private Sku()
        {
        }

        public Sku(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "SKU cannot be empty.",
                    nameof(value));

            value = value.Trim().ToUpperInvariant();

            if (value.Length < 4)
                throw new ArgumentException(
                    "SKU must contain at least 4 characters.",
                    nameof(value));

            Value = value;
        }

        public override string ToString()
            => Value;
    }
}
