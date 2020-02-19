namespace EnterpriseFramework.Project.DataAccess.Migrations
{
    using EnterpriseFramework.Project.Entities.Concrete.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "DatabaseContext";
        }

        protected override void Seed(EnterpriseFramework.Project.DataAccess.Concrete.EntityFramework.DatabaseContext context)
        {
            for (int i = 0; i < 40; i++)
            {
                Product product = new Product()
                {
                    Id = i + 1,
                    Name = FakeData.NameData.GetFirstName(),
                    Description = FakeData.PlaceData.GetStreetName(),
                    Price = FakeData.NumberData.GetNumber(1, 100)

                };

                context.products.AddOrUpdate(product);
            }

            context.SaveChanges();

            List<Product> listProduct = context.products.ToList();

            for (int i = 0; i < listProduct.Count - 1; i++)
            {
                Comment comment = new Comment()
                {
                    Id = i + 1,
                    Text = FakeData.NameData.GetCompanyName(),
                    UserBy = FakeData.NameData.GetFirstName(),
                    ProductId = listProduct[i].Id
                };

                context.comments.AddOrUpdate(comment);
            }

            context.SaveChanges();

            User userone = new User()
            {
                UserName = "03Alican",
                FirstName = "Alican",
                LastName = "Yilmaz",
                Email = "alicany@mail",
                Password = "1a2b3c"

            };

            context.users.AddOrUpdate(userone);

            User usertwo = new User()
            {
                UserName = "05Alican",
                FirstName = "Ali",
                LastName = "Can",
                Email = "contact@alicanyilmaz",
                Password = "a1b2c3"

            };

            context.users.AddOrUpdate(usertwo);

            context.SaveChanges();

            List<User> users = context.users.ToList();

            Role roleone = new Role()
            {
                Name="Admin",
            };

            context.roles.AddOrUpdate(roleone);

            Role roletwo = new Role()
            {
                Name = "Student",
            };

            context.roles.AddOrUpdate(roletwo);

            Role rolethree = new Role()
            {
                Name = "Editor",
            };

            context.roles.AddOrUpdate(rolethree);

            context.SaveChanges();

            List<Role> roles = context.roles.ToList();

            UserRoles userRolesone = new UserRoles()
            {
               UserId=users[0].Id,
               RoleId=roles[1].Id,
            };

            context.userRoles.AddOrUpdate(userRolesone);

            UserRoles userRolestwo = new UserRoles()
            {
                UserId = users[1].Id,
                RoleId = roles[0].Id,
            };

            context.userRoles.AddOrUpdate(userRolestwo);

            context.SaveChanges();
        }
    }
}
