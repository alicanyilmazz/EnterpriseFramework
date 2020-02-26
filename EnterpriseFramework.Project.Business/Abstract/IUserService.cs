using EnterpriseFramework.Project.Entities.ComplexTypes;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName,string password);
        List<UserRoleItem> getUserRoles(User user);
    }
}
