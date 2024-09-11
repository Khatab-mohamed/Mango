namespace Core.Events;

public class IntegrationEvent : IIntegrationEvent
{
    public DefaultIdType Id { get; }
    public DateTime CreationDate { get; }

    public IDictionary<string, object> MetaData { get; }

    protected IntegrationEvent()
    {
        Id = DefaultIdType.NewGuid();
        CreationDate = DateTime.UtcNow;
        MetaData = new Dictionary<string, object>();
    }
}
