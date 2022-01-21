using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{
    //gerçekleşecek olay ile ilgili bir interfaece tanımladım. entity içerisinde bir state değerinde bir değişim sonucu bu event başka bir entity haber verecek. Fiyat değiştinde bu ürünü fav eklediğinde kullanıcılara eposta gönderme gibi. sşsteme makale girildiğinde takip edilen yazarın son makalesini eposta olarak alma
    public interface IDomainEvent
    {
        public string Name { get; set; } //eventName, OrderedEvent, ShippedEvent, PriceChanged
    }
}
