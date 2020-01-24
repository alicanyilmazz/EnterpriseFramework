using EnterpriseFramework.Core.DataAccess;
using EnterpriseFramework.Project.Entities.ComplexTypes;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //You can use this scope for specific Query (Such as Join Queries) on Product Table

        List<ProductDetail> GetProductDetails();
    }
}
