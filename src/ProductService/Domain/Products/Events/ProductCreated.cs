using Domain.Common;
using Domain.Products.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products.Events
{
    public sealed record ProductCreated : DomainEvent
    {
        public ProductId ProductId { get; }
        public string Name { get; set; }
        public string SKU { get; set; }
    }
}
