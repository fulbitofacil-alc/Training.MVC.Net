using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CPS.Contract;
using CPS.Persistence.CompositionRoot;
using NHibernate;

namespace CPS.Business
{
    public class ClaimBusiness
    {
        private ISession _session;

        public ClaimBusiness()
        {
            InMemoryBootstrapper.Bootstrap();
            _session = InMemoryBootstrapper.GetSession();

        }
        public ClaimDto Create(ClaimDto claim)
        {
            throw new NotImplementedException();
        }

        public ClaimDto Get(int id)
        {
            return new ClaimDto
            {
                Client = new ClientDto { DocumentId = "123123", Name = "UZi", LastName = "Mamani" },
                Id = 1,
                ExpectedDate = DateTime.Today.AddDays(30),
                NotifyDate = DateTime.Today.AddDays(25),
               ToFavorOfCustomer = false
            };
        }
    }
}
