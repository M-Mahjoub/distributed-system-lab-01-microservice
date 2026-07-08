using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products.ValueObjects
{
    public record Money
    {
        public Money(decimal amount, string currency)
        {
            if (amount < 0)
                throw new ArgumentException("amount");

            Amount = amount;
            Currency = currency;
        }
        public decimal Amount { get; init; }
        public string Currency { get; init; }
    }
}
