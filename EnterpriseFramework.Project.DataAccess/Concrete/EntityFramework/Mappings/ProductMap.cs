using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product", @"dbo");

            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Id).HasColumnOrder(0);
            //Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Name).HasColumnOrder(1);
            Property(x => x.Name).IsRequired();
            Property(x => x.Name).HasMaxLength(25);

            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.Description).HasColumnOrder(2);
            Property(x => x.Description).IsRequired();
            Property(x => x.Description).HasMaxLength(300);

            Property(x => x.Price).HasColumnName("Price");
            Property(x => x.Price).HasColumnOrder(3);
            Property(x => x.Price).IsRequired();
        }
    }
}
