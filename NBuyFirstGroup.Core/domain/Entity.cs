using NbuyFirstGroup.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{

    //bu sınıftan insatance alınamaz ama diğer sınıflar bu sınıftan instance alığ entity özelliği kazanacaklar. her entity  id si old için bu sınıf içine koydık. entitylerin hepsi event fırlatabilir oluyor. işi bitince eventi fırlatıp içi başka bir nesneye bırakacağız.
    public abstract class Entity
    {
        public string Id { get; set; }
        //public abstract void Raise(IDomainEvent @event);

    }
    public class ProductCreated : IDomainEvent
    {
        public string Name { get; set; }
    }

    public class Product : Entity
    {
        public void IncreasePrice(double newPrice)
        {
            DomainEvent.Raise(new ProductCreated());
        }
    }

}
