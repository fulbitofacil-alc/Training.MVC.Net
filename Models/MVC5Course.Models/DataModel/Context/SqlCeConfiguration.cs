using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MVC5Course.Models.DataModel.Context
{
    public class SqlCeConfiguration : DbConfiguration
    {
        public SqlCeConfiguration()
        {
            SetExecutionStrategy("System.Data.DataClient", () => new DefaultExecutionStrategy());
            SetDefaultConnectionFactory(new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0", "",
                @"Data Source=|DataDirectory|\ChinookDb.sdf"));


        }
    }
}