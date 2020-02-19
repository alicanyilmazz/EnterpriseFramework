using EnterpriseFramework.Core.DataAccess.EntityFramework;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfUserRolesDal: EntityFrameworkEntityRepositoryBase<UserRoles, DatabaseContext>, IUserRolesDal
    {
    }
}
