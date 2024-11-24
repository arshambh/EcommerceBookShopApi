using System.ComponentModel.DataAnnotations.Schema;
using Comman.Domain;

namespace Common.Domain
{
    public class BaseEntity
    {
        public long Id { get; private set; }
        public DateTime CreationDate { get; }

        public BaseEntity()
        {
            CreationDate = new DateTime();
        }
    }

    public class AggregateRoot : BaseEntity
    {
        private readonly List<BaseDomainEvent> _domainEvents = [];

        [NotMapped]
        public List<BaseDomainEvent> DomainEvents => _domainEvents;

        public void AddDomainEvent(BaseDomainEvent eventItem)
        {
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(BaseDomainEvent eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }
    }
}