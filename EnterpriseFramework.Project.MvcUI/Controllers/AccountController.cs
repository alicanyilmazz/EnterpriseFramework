using EnterpriseFramework.Core.CrossCuttingConcerns.Security.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseFramework.Project.MvcUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public string Login()
        {
            AuthenticationHelper.CreateAuthCookie(new Guid(),"AlicanYilmaz","alicanyilmaz101@gmail.com",DateTime.Now.AddDays(15),new[] {"Admin"},false,"Alican","Yilmaz");
            return "User is authenticated!";
        }
    }
}