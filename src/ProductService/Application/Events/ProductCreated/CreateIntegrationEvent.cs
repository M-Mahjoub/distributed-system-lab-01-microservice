using Application.Abstractions;
using Application.IntegrationEvents;
using Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events.ProductCreated
{
    public class CreateIntegrationEvent : IDomainEventHandler<Domain.Events.ProductCreated>
    {
        public IIntegrationEventStore _integrationEventStore { get; set; }

        public CreateIntegrationEvent(IIntegrationEventStore _integrationEventStore)
        {
            this._integrationEventStore = _integrationEventStore;
        }
        public Task HandleAsync(Domain.Events.ProductCreated domainEvent)
        {
            ProductCreatedIntegrationEvent productCreatedIntegrationEvent = new ProductCreatedIntegrationEvent();
            _integrationEventStore.SaveAsync(productCreatedIntegrationEvent);

            return Task.CompletedTask;
        }
    }
}
