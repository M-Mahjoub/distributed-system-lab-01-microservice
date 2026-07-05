using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events
{
    public class ProductCreated : Domain.Common.IDomainEvent
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }

        public Guid EventId { get; set; }

        public DateTime OccurredOnUtc { get; set; }
    }
}
