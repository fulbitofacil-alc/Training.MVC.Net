using System;
using CPS.Domain.Componentes;

namespace CPS.Domain
{
    public class Client : Entity
    {
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string DocumentId { get; set; }
        public virtual Address Address { get; set; }
        public virtual DateTime BecomeAClientOn { get; set; }
    }
}
