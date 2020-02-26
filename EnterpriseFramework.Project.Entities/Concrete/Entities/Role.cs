using EnterpriseFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Entities.Concrete.Entities
{
    public class Role : IEntity
    {
        public Role()
        {
            userRoles = new List<UserRoles>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserRoles> userRoles { get; set; }

    }
}
