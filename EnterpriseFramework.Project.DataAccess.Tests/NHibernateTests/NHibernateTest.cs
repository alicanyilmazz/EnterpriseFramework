﻿using System;
using EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Dals;
using EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseFramework.Project.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_product()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList();

            Assert.AreEqual(40, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_product()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());

            var result = nhProductDal.GetList(p => p.Id > 20 && p.Id < 30);
            Assert.AreEqual(9, result.Count);
        }
    }
}
