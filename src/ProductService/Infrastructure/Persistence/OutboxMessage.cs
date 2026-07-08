using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OutboxMessage
    {
        public Guid Id { get; }

        public string Type { get; }

        public string Payload { get; }

        public DateTime OccurredOn { get; }

        public DateTime? ProcessedOn { get; }

        public int RetryCount { get; }

        public string? Error { get; }
    }
}
