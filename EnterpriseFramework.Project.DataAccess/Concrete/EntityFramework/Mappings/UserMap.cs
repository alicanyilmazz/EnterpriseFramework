using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Users");

            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Id).HasColumnOrder(0);
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.UserName).HasColumnOrder(1);
            Property(x => x.UserName).IsRequired();
            Property(x => x.UserName).HasMaxLength(25);

            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.FirstName).HasColumnOrder(2);
            Property(x => x.FirstName).IsRequired();
            Property(x => x.FirstName).HasMaxLength(25);

            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.LastName).HasColumnOrder(3);
            Property(x => x.LastName).IsRequired();
            Property(x => x.LastName).HasMaxLength(25);

            Property(x => x.Password).HasColumnName("Password");
            Property(x => x.Password).HasColumnOrder(4);
            Property(x => x.Password).IsRequired();
            Property(x => x.Password).HasMaxLength(25);

            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Email).HasColumnOrder(5);
            Property(x => x.Email).IsRequired();
            Property(x => x.Email).HasMaxLength(25);
        }
    }
}
