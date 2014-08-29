using System;
using System.Collections.Generic;
using System.Linq;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Base;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Components;
using MVC5Course.Automapper.Domain.ComplexDomainExample.Enums;

namespace MVC5Course.Automapper.Domain.ComplexDomainExample
{
    public class Client : Entity
    {
        public Client()
        {
            Subscriptions = new List<Suscription>();
        }

        public virtual string UserName { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual RatingEnum Rating { get; set; }
        public virtual DateTime? JoinDate { get; set; }
        public virtual IList<Suscription> Subscriptions { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual DocumentTypeEnum DocumentType { get; set; }
        public virtual string DocumentNumber { get; set; }
        public virtual Location Address { get; set; }
        public virtual bool Enabled { get; set; }

        public virtual void AddSubscription(Suscription subscription)
        {
            subscription.Client = this;
            Subscriptions.Add(subscription);
            if (subscription.IsActive && Subscriptions.Count>0)
            {
                JoinDate = DateTime.Now;
            }
        }

        public virtual bool IsActive()
        {
            return Subscriptions.Any(subscription => subscription.IsActive);
        }

    }
}