using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{
    public interface IDomainEventHendler<TEvent> where TEvent:IDomainEvent
    {
        void Hendler(TEvent @event);
    }
}
