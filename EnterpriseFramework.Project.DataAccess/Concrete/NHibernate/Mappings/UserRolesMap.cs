using EnterpriseFramework.Project.Entities.Concrete.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Mappings
{
   public class UserRolesMap: ClassMap<UserRoles>
    {
        public UserRolesMap()
        {
            Table(@"Users");
            LazyLoad();

            Id(x => x.Id).Column("Id").GeneratedBy.Identity();
            Map(x => x.RoleId).Column("RoleId");
            Map(x => x.UserId).Column("UserId");
                                
        }
    }
}
