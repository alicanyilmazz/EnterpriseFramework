using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseFramework.Project.Entities.Concrete.Entities;

namespace EnterpriseFramework.Project.Business.ServiceAdapters.Abstract
{
    public interface ICitizenshipVerificationService
    {
        bool ValidateUser(User user);
    }
}
