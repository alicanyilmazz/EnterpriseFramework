using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.Business.DependencyResolvers.Ninject;
using EnterpriseFramework.Project.Entities.Concrete.Entities;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService: IProductService
{
    IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public ProductService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

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
        _productService.TransactionalOperations(adding_product,updating_product);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }
}