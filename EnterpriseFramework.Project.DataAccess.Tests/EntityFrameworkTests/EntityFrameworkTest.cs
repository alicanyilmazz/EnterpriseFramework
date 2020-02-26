using System;
using EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Dals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseFramework.Project.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_product()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList();

            Assert.AreEqual(19,result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_product()
        {
            EfProductDal efProductDal = new EfProductDal();

            var result = efProductDal.GetList(p => p.Name.Contains("a"));
            Assert.AreEqual(9, result.Count);


        }
    }
}

