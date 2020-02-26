using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.ComplexTypes;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System.Collections.Generic;

namespace EnterpriseFramework.Project.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName==userName && u.Password==password);
        }
        public List<UserRoleItem> getUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
