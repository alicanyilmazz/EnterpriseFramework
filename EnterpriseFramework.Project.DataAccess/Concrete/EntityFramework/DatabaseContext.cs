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
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserRoles> userRoles { get; set; }
        public DbSet<Role> roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRolesMap());
            modelBuilder.Configurations.Add(new RoleMap());
        }
    }
}
