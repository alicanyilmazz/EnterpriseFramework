using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseFramework.Project.MvcUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var model = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Entities.Concrete.Entities.Product
            { 
                Id=1,
                Price=23,
                Description="Intel Core i7 processor",
                Name="Premium Asus Rog"             
            
            });

            return "Added.";
        }

        public string AddAndUpdate()
        {
            _productService.TransactionalOperations(new Entities.Concrete.Entities.Product
            {
                Id = 1,
                Price = 3,
                Description = "Alican processor",
                Name = "Phone"

            },
            new Entities.Concrete.Entities.Product
            {
                Id = 1,
                Price = 28,
                Description = "Yılmaz processor",
                Name = "Phone"

            });

            return "Done!";
        }
    }
}