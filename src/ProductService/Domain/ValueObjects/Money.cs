using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record Money
    {
        public Money(decimal amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
        public decimal Amount { get; init; }
        public string Currency { get; }
    }
}
