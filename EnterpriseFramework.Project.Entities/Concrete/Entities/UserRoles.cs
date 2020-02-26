using EnterpriseFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Entities.Concrete.Entities
{
    public class UserRoles : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public User user { get; set; }
        public Role role { get; set; }

    }
}
