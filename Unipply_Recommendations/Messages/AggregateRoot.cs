using System.Collections.Generic;
using Users.Domain.Events.Interfaces;

namespace Unipply_Recommendations.Messages
{
    public class AggregateRoot
    {
        private readonly List<IDomainEvent> _events = new List<IDomainEvent>();
        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent @event)
        {
            _events.Add(@event);
        }
    }
}
