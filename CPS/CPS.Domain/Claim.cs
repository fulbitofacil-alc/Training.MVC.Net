using System;
using System.Collections.Generic;
using System.Linq;
using CPS.Domain.Componentes;

namespace CPS.Domain
{
    public class Claim : Entity
    {
        public Claim()
        {
            Actions = new List<Action>();
        }
        public virtual DateTime RecordDate { get; set; }
        public virtual DateTime NotifyDate { get; set; }
        public virtual Address NotifyAddress { get; set; }
        public virtual Client Client { get; set; }
        public virtual Incident Incident { get; set; }
        public virtual Branch ClaimBranch { get; set; }
        public virtual IList<Action> Actions { get; set; }
        public virtual Workflow Workflow { get; set; }
        public virtual Boolean ToFavorOfCustomer { get; set; }
        public virtual DateTime ExpectedDate { get; set; }
        public virtual void AddAction(Action accion)
        {
            accion.Claim = this;
            Actions.Add(accion);
        }
    }
}
