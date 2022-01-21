using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{
    //bu sınıf bir event raise olduktan sonra eventin ilgili handler seck edilmesinden sorumlu olan ara bir yapı görevi görür. böylece event üzerinden taşınan bilgileri bağımsız bir şekilde sisteme tanıtmış olan handlera iletmekten sorumludur.
    public interface IDomainEventDispatcher<TEvent> where TEvent:IDomainEvent
    {
        void Dispatch(TEvent @event);
    }
}
