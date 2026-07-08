using Domain.Common;
using Domain.Products.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products.Events
{
    public sealed record ProductRenamed : DomainEvent
    {
        public ProductId ProductId { get; }

        public string OldName { get; }

        public string NewName { get; }
    }
}
