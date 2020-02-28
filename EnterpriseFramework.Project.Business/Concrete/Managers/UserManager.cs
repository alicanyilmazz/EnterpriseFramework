using System;
using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.ComplexTypes;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System.Collections.Generic;
using EnterpriseFramework.Core.Aspects.PostSharp.CacheAspects;
using EnterpriseFramework.Project.Business.ServiceAdapters.Abstract;
using EnterpriseFramework.Core.Aspects.PostSharp.ValidationAspects;
using EnterpriseFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using EnterpriseFramework.Project.Business.ValidationRules.FluentValidation;

namespace EnterpriseFramework.Project.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private ICitizenshipVerificationService _citizenship;

        public UserManager(IUserDal userDal, ICitizenshipVerificationService citizenship)
        {
            _userDal = userDal;
            _citizenship = citizenship;
        }
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName && u.Password == password);
        }
        public List<UserRoleItem> getUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }

        [FluentValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void addUser(User user)
        {
            if (_citizenship.ValidateUser(user) == false)
            {
                throw new Exception("Identity verification is not valid!");
            }

            _userDal.Add(user);
        }

    }
}
