using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseFramework.Project.Business.ServiceAdapters.Abstract;
using EnterpriseFramework.Project.Business.TurkishCitizenshipVerifyServiceReference;
using EnterpriseFramework.Project.Entities.Concrete.Entities;

namespace EnterpriseFramework.Project.Business.ServiceAdapters.Concrete
{
    public class CitizenshipVerificationServiceAdapter : ICitizenshipVerificationService
    {
        //TODO you can adding new DataOfBirth and Identity properties for using User instance this operations only provides implementation approach
        public bool ValidateUser(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64("12345678910"), "Alican", "Yilmaz", 1995);
        }
    }
}
