using EnterpriseFramework.Core.DataAccess;
using EnterpriseFramework.Core.DataAccess.EntityFramework;
using EnterpriseFramework.Core.DataAccess.NHibernate;
using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.Business.Concrete.Managers;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework;
using EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Dals;
using EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope(); // Other option : NhProductDal 

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();


            Bind(typeof(IQueryableRepository<>)).To(typeof(EntityFrameworkQueryableRepository<>));
            Bind<DbContext>().To<DatabaseContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    } 
}
