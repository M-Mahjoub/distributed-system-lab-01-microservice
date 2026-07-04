using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public record Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
