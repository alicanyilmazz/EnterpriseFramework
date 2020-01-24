using EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.Mappings;
using EnterpriseFramework.Project.DataAccess.Migrations;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext():base("DatabaseContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Configuration>("DatabaseContext"));
            //Database.SetInitializer<DatabaseContext>(null);
            //Database.SetInitializer(new DatabaseInitializer());
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Comment> comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CommentMap());
        }
    }
}
