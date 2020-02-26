using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RoleMap: EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable("Roles");

            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Id).HasColumnOrder(0);
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Name).HasColumnOrder(1);
            Property(x => x.Name).IsRequired();
            Property(x => x.Name).HasMaxLength(25);
        }
    }
}
