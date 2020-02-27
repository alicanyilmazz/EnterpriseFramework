using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.Business.DependencyResolvers.Ninject;
using EnterpriseFramework.Project.Business.ServiceContracts.Wcf;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService : IProductDetailService
{
    IProductService _productService = InstanceFactory.GetInstance<IProductService>();

    public Product Add(Product product)
    {
        return _productService.Add(product);
    }

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }

    public void TransactionalOperations(Product adding_product, Product updating_product)
    {
        _productService.TransactionalOperations(adding_product, updating_product);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }
}