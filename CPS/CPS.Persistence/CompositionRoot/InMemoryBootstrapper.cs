using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ConfOrm;
using CPS.Persistence.ConfORM;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping;
using NHibernate.Mapping.ByCode;

namespace CPS.Persistence.CompositionRoot
{
    public static class InMemoryBootstrapper
    {
        private static ISessionFactory SessionFactory { get; set; }

        private static Configuration _configuration;
        private static IDbConnection _connection;
        private static HbmMapping _mappings;

        public static ISession GetSession()
        {
            return SessionFactory.OpenSession(_connection);
        }
        public static void Bootstrap()
        {
            var orm = MapConfiguration.GetObjectRelationalMapper();

            _mappings = MapConfiguration.GetMapings(orm);
            _configuration = GetConfiguration(_mappings);
            _configuration.AddAuxiliaryDatabaseObject(CreateHighLowScript(orm));
            SessionFactory = _configuration.BuildSessionFactory();

            _connection = MapConfiguration.BuildSchema(SessionFactory.OpenSession(), _configuration);

        }

        private static Configuration GetConfiguration(HbmMapping mappings)
        {
            var config = new Configuration();
            config.DataBaseIntegration(db =>
            {
                db.ConnectionReleaseMode = ConnectionReleaseMode.OnClose;
                db.ConnectionString = "data source=:memory:";
                db.LogFormattedSql = true;
                db.LogSqlInConsole = true;
                db.Dialect<SQLiteDialect>();
                db.Driver<SQLite20Driver>();
            });
            config.AddDeserializedMapping(mappings, "voffice");

            return config;
        }


        public static void PrintMapping()
        {
            Debug.WriteLine(_mappings.AsString());
        }

        private static IAuxiliaryDatabaseObject CreateHighLowScript(IDomainInspector orm)
        {
            var script = new StringBuilder(1500);
            script.AppendLine("DELETE FROM NextHighValues;");
            script.AppendLine("ALTER TABLE NextHighValues ADD Entity VARCHAR(128);");
            script.AppendLine("CREATE INDEX IdxNextHighVauesEntity ON NextHighValues (Entity ASC);");
            foreach (var entity in MapConfiguration.DomainEntities().Where(orm.IsRootEntity))
            {
                script.AppendLine(string.Format("INSERT INTO NextHighValues (Entity, NextHigh) VALUES ('{0}',1);", entity.Name));
            }
            var sql = new SimpleAuxiliaryDatabaseObject(script.ToString(), null,
                new HashedSet<string>()
                {
                    typeof (MsSql2005Dialect).FullName,
                    typeof (MsSql2008Dialect).FullName,
                    typeof (SQLiteDialect).FullName,
                    typeof (Oracle10gDialect).FullName
                });
            return sql;
        }
    }
}