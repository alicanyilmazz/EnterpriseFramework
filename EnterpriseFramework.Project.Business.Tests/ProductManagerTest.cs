using System;
using EnterpriseFramework.Project.Business.Concrete.Managers;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EnterpriseFramework.Project.Business.Tests
{
    [TestClass]
    public class ProductManagerTest
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product() { Id = 1, Name = "Phone",Description = "This is a device.", Price = 12 });
        }
    }
}
