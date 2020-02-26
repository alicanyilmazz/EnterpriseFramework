using EnterpriseFramework.Core.DataAccess.EntityFramework;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.ComplexTypes;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfUserDal : EntityFrameworkEntityRepositoryBase<User, DatabaseContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from r in context.roles
                             join ur in context.userRoles
                             on r.Id equals ur.RoleId
                             where ur.UserId == user.Id
                             select new UserRoleItem
                             {
                                 RoleName = r.Name
                             };
                return result.ToList();
            }
        }
    }
}
