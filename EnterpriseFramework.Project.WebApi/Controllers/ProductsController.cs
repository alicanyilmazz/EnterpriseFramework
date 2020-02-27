using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace EnterpriseFramework.Project.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public List<Product> Get()
        {
            return _productService.GetAll();
        }

    }
}
