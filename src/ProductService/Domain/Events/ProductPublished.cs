using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events
{
    public class ProductPublished : IDomainEvent
    {
        public Guid EventId => throw new NotImplementedException();

        public DateTime OccurredOnUtc => throw new NotImplementedException();
    }
}
