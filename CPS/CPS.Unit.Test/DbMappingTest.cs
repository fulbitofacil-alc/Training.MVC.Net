using System.Diagnostics;
using System.Linq;
using CPS.Domain;
using CPS.Domain.Componentes;
using CPS.Persistence.CompositionRoot;
using FluentAssertions;
using NHibernate.Linq;
using NUnit.Framework;

namespace CPS.Unit.Test
{
    [TestFixture]
    public class DbMappingTest
    {
        private NHibernate.ISession _session;
        private int _idClient;
        [TestFixtureSetUp]
        public void Init()
        {
            InMemoryBootstrapper.Bootstrap();
            _session = InMemoryBootstrapper.GetSession();
            _session.Should().NotBeNull();

            var cliente = new Client { Name = "Uzi", Address = new Address { City = "LIma" } };
            _session.Save(cliente);
            _idClient = cliente.Id;
            _session.Flush();
        }

        [Test]
        public void CreatingClient_Test()
        {
            var mycliente = _session.Get<Client>(_idClient);
            mycliente.Id.Should().Be(_idClient);

        }

        [Test]
        public void UpdateClient_Test()
        {
            var mycliente = _session.Get<Client>(_idClient);
            mycliente.LastName = "Mamani";
            _session.Update(mycliente);
            var cliente = new Client { Name = "Juan", Address = new Address { City = "LIma" } ,LastName = "Perez"};
            _session.Save(cliente);
            _session.Flush();
            var updatedClient = _session.Get<Client>(_idClient);
            updatedClient.LastName.Should().Be("Mamani");

        }

        [Test]
        public void UpdateClientSessionFlush_Test()
        {
            var updatedClient = _session.Query<Client>().FirstOrDefault(x => x.LastName == "Perez");
            updatedClient.LastName.Should().Be("Perez");

        }
    }
}