using EnterpriseFramework.Project.Business.Abstract;
using EnterpriseFramework.Project.Business.ValidationRules.FluentValidation;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System.Collections.Generic;
using EnterpriseFramework.Core.Aspects.PostSharp.ValidationAspects;
using EnterpriseFramework.Core.Aspects.PostSharp.TransactionAspects;
using EnterpriseFramework.Core.Aspects.PostSharp.CacheAspects;
using EnterpriseFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using AutoMapper;
using EnterpriseFramework.Core.Utilities.Mappings.AutoMapper;
using EnterpriseFramework.Core.Aspects.PostSharp.AuthorizationAspects;

namespace EnterpriseFramework.Project.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [CacheAspect(typeof(MemoryCacheManager), 60)]
        //[PerformanceCounterAspect(2)]  --> PerformanceCounterAspect using Assembly level
        //[SecuredOperation(Roles = "Admin,Editor")]
        public List<Product> GetAll()
        {
            //var products = AutoMapperHelper.MapToSameTypeList<Product>(_productDal.GetList());
            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            return products;
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidator))]
        public void TransactionalOperations(Product adding_product, Product updating_product)
        {
            _productDal.Add(adding_product);
            //Business Codes
            _productDal.Update(updating_product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

    }
}
