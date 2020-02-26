using EnterpriseFramework.Core.CrossCuttingConcerns.Security.Web;
using EnterpriseFramework.Project.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseFramework.Project.MvcUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public string Login(string userName, string password) //We can user Querystring for testing "AuthenticationHelper" as simply.
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(new Guid(), user.UserName, user.Email, DateTime.Now.AddDays(15),_userService.getUserRoles(user).Select(u=>u.RoleName).ToArray(), false, user.FirstName, user.LastName);
                return "User is authenticated!";
            }

            return "User is not authenticated!";
        }
    }
}