using System.Collections.Generic;
using CPS.Domain.Componentes;

namespace CPS.Domain
{
    public class Branch : Entity
    {
        public virtual string Name { get; set; }
        public virtual Address Address { get; set; }
    }
}
