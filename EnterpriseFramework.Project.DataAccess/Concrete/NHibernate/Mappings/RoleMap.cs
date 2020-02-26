using EnterpriseFramework.Project.Entities.Concrete.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Mappings
{
    public class RoleMap:ClassMap<Role>
    {
        public RoleMap()
        {
            Table(@"Roles");
            LazyLoad();

            Id(x => x.Id).Column("Id").GeneratedBy.Identity();
            Map(x => x.Name).Column("Name").Length(25).Not.Nullable();

            HasMany(x => x.userRoles).KeyColumn("RoleId").Inverse().Cascade.AllDeleteOrphan();

        }
    }
}
