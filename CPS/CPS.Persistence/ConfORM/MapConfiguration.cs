using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using ConfOrm;
using ConfOrm.NH;
using ConfOrm.Patterns;
using ConfOrm.Shop.Appliers;
using ConfOrm.Shop.CoolNaming;
using ConfOrm.Shop.InflectorNaming;
using ConfOrm.Shop.Inflectors;
using ConfOrm.Shop.Packs;
using CPS.Domain;
using CPS.Domain.Componentes;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;

namespace CPS.Persistence.ConfORM
{
    public class MapConfiguration
    {
        private static IEnumerable<Type> domainEntities;

        public static IDbConnection BuildSchema(ISession Session, Configuration configuration)
        {
            var export = new SchemaExport(configuration);
            var connection = Session.Connection;
            export.Execute(true, true, false, connection, null);
            return connection;
        }

        public static HbmMapping GetMapings(ObjectRelationalMapper orm)
        {

            domainEntities =
                typeof(Entity).Assembly.GetTypes()
                    .Where(t => typeof(Entity).IsAssignableFrom(t) && !t.IsGenericType)
                    .ToList();
            orm.TablePerClass(domainEntities);

            orm.Cascade<Claim, CPS.Domain.Action>(CascadeOn.None);
            orm.Cascade<Branch, Claim>(CascadeOn.None);
            orm.Cascade<Domain.Action,Document>(CascadeOn.All);
            

            orm.Component<Address>();
            orm.Component<Incident>();
            orm.Component<ContactInfo>();

            var patterns = new SafePropertyAccessorPack().Merge(new OneToOneRelationPack(orm))
                .Merge(new BidirectionalManyToManyRelationPack(orm))
                .Merge(new BidirectionalOneToManyRelationPack(orm))
                .Merge(new DiscriminatorValueAsClassNamePack(orm))
                .Merge(new CoolColumnsNamingPack(orm))
                .Merge(new TablePerClassPack())
                .Merge(new ListIndexAsPropertyPosColumnNameApplier())
                .Merge(new PluralizedTablesPack(orm, new EnglishInflector()));

               // .Merge(new MsSQL2008DateTimeApplier());


            var mapper = new Mapper(orm, patterns);

            var mapping = mapper.CompileMappingFor(domainEntities);
            Debug.WriteLine(mapping.AsString());
            return mapping;
        }
        public static ObjectRelationalMapper GetObjectRelationalMapper()
        {
            var orm = new ObjectRelationalMapper();
            orm.Patterns.PoidStrategies.Add(new HighLowPoidPattern(poidProperty => new
            {
                table = "NextHighValues",
                column = "NextHigh",
                max_lo = 100,
                where = string.Format("Entity = '{0}'", poidProperty.ReflectedType.GetRootEntity(orm).Name)
            }));
            return orm;
        }

        public static IEnumerable<Type> DomainEntities()
        {
            return domainEntities;
        }
    }
}