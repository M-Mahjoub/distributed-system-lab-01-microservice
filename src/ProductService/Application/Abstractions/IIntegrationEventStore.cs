using Application.IntegrationEvents;

namespace Application.Abstractions
{
    public interface IIntegrationEventStore
    {
        Task SaveAsync(IIntegrationEvent integrationEvent);
    }
}
