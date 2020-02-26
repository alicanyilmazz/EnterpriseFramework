using EnterpriseFramework.Project.Entities.Concrete.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table(@"Users");
            LazyLoad();

            Id(x => x.Id).Column("Id").GeneratedBy.Identity();
            Map(x => x.Email).Column("Email").Length(25).Not.Nullable();
            Map(x => x.FirstName).Column("FirstName").Length(25).Not.Nullable();
            Map(x => x.LastName).Column("LastName").Length(25).Not.Nullable();
            Map(x => x.Password).Column("Password").Length(25).Not.Nullable();
            Map(x => x.UserName).Column("UserName").Length(25).Not.Nullable();

            HasMany(x => x.userRoles).KeyColumn("UserId").Inverse().Cascade.AllDeleteOrphan();
        }
    }
}
