using System;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public abstract class SuscriptionDetail : Entity
    {
        public virtual Suscription Suscription { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal Discount { get; set; }

        public virtual decimal Total()
        {
            return Math.Round(Price*(1 - Discount/100)*Quantity,0);
        }
    }
    public abstract class SubscriptionDetail<TDetail> : SuscriptionDetail
    {
        public virtual TDetail Resource { get; set; }
        
    }

    public class OfficeSubscription : SubscriptionDetail<Office>
    {

    }

    public class ServiceSubscription : SubscriptionDetail<Service>
    {

    }
}
