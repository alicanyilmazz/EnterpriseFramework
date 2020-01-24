using EnterpriseFramework.Core.DataAccess.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(c=>c.FromConnectionStringWithKey("DatabaseContext"))).Mappings(t=>t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
