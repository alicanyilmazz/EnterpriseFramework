using EnterpriseFramework.Core.DataAccess;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Abstract
{
    public interface IRoleDal : IEntityRepository<Role>
    {
    }
}
