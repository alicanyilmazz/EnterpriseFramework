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

        }
    }
}
