using EnterpriseFramework.Core.DataAccess.EntityFramework;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.ComplexTypes;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfProductDal : EntityFrameworkEntityRepositoryBase<Product, DatabaseContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from p in context.Products
                             join c in context.comments on p.Id equals c.ProductId
                             select new ProductDetail
                             {
                                 ProductId = p.Id,
                                 ProductName = p.Name,
                                 CommentText = c.Text
                             };

                return result.ToList();
            }
        }
    }
}
