using NBuyFirstGroup.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyFirstGroup.Core.domain
{
    public static class DomainEvent
    {
        /*Bu sınıfı IOC ile singleton bir instancea bağlayacağız uygulama ilk ayağa kalktığında bu dispatcher sınıgı static tanımlamamızın sebebi tek bir instance ile uygulama genelinde bu sevk edici arkadaşı çalıştırmak. IOC üzerinden tanımlanmış tüm handlerlara dispatcher üzerindeki Dispatch methodu ile eerişip tetiklenmelkerini sağlayacağız.Fakat bunu bu katmanda değil uygulamanın infrastructure katmanında yapacağız.*/

        //DomainEvent taskın bir özelliği değiştiği zaman kullanıcılara mail vs. bir şey gitmesi lazıkm
        //bir state değişiminde entitydeki event fırlatman lazım.

        private static IDomainEventDispatcher<IDomainEvent> domainEventDispatcher { get; set; }

        public static void Raise(IDomainEvent @event)
        {
            domainEventDispatcher.Dispatch(@event);
        }
    }
}

