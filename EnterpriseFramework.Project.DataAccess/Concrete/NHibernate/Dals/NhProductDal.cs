using EnterpriseFramework.Core.DataAccess.NHibernate;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.ComplexTypes;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Dals
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Comment>()
                             on p.Id equals c.ProductId
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
