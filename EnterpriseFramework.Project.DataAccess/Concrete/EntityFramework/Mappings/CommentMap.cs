using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CommentMap: EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            ToTable("Comments", "ETrade");

            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Id).HasColumnOrder(0);
            //this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            Property(x => x.Text).HasColumnName("Text");
            Property(x => x.Text).HasColumnOrder(1);
            Property(x => x.Text).IsRequired();
            Property(x => x.Text).HasMaxLength(300);

            Property(x => x.UserBy).HasColumnName("UserBy");
            Property(x => x.UserBy).HasColumnOrder(2);
            Property(x => x.UserBy).IsRequired();
            Property(x => x.UserBy).HasMaxLength(25);

            Property(x => x.ProductId).HasColumnName("ProductId");
            Property(x => x.ProductId).HasColumnOrder(3);
            Property(x => x.ProductId).IsRequired();

            //Bir Comment bir Product 'a aittir.Ama bir Product in birden fazla Comment 'e sahip olabilir.
            HasRequired(x => x.product)
              .WithMany(y => y.comments)
              .HasForeignKey(x => x.ProductId);
        }
    }
}
