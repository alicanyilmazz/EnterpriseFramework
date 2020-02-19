using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserRolesMap: EntityTypeConfiguration<UserRoles>
    {
        public UserRolesMap()
        {
            ToTable("UserRoles", @"dbo");

            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Id).HasColumnOrder(0);
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.Id).HasColumnOrder(1);

            Property(x => x.RoleId).HasColumnName("RoleId");
            Property(x => x.Id).HasColumnOrder(2);

            // User - User_Role Common Table Mant to Many
            this.HasRequired(x => x.user)
              .WithMany(y => y.userRoles)
              .HasForeignKey(x => x.UserId);

            // Role - User_Role Common Table Mant to Many
            this.HasRequired(x => x.role)
              .WithMany(y => y.userRoles)
              .HasForeignKey(x => x.RoleId);
        }
    }
}
