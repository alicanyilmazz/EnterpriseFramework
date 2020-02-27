using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Business.ServiceContracts.Wcf
{
    [ServiceContract]
    public interface IProductDetailService
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product GetById(int id);

        [OperationContract]
        Product Add(Product product);

        [OperationContract]
        Product Update(Product product);

        [OperationContract]
        void TransactionalOperations(Product adding_product, Product updating_product);

    }
}
