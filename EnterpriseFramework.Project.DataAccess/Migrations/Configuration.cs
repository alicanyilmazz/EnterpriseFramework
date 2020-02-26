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
            //Adding Product
            #region

            if (!context.Products.Any())
            {
                var productsList = new List<Product>()
                {
                    new Product(){Name="KF552",Description="Asus Rog",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Airstar",Description="Lenovo",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Via",Description="Casper",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Avatar",Description="MSI",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="X6",Description="Iphone",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="S7 Edge",Description="Samsung",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="S9 Edge",Description="Samsung",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Galaxy S6",Description="Samsung",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Via Phone",Description="Casper",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Daker",Description="Acer",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Sage",Description="IBM",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Routon",Description="Kennon",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="M12",Description="Xaimio",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="M9",Description="Xaimio Mi",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Lotus",Description="Asus",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Ascer",Description="Steel Series",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="190C",Description="Philips",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="JKP21",Description="Alcatel",Price=FakeData.NumberData.GetNumber(1, 300)},
                    new Product(){Name="Sorana",Description="Asus",Price=FakeData.NumberData.GetNumber(1, 300)}
                };

                productsList.ForEach(product => context.Products.Add(product));
                context.SaveChanges();
            }


            #endregion

            List<Product> listProduct = context.Products.ToList();

            //Adding Comments
            #region

            if (!context.comments.Any())
            {
                var commentList = new List<Comment>()
                {
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[0].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[1].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[2].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[3].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[4].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[5].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[6].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[7].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[8].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[9].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[10].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[11].Id},
                    new Comment(){Text=FakeData.NameData.GetCompanyName(),UserBy=FakeData.NameData.GetFirstName(),ProductId=listProduct[12].Id}

                };

                commentList.ForEach(comment => context.comments.Add(comment));
                context.SaveChanges();
            }

            #endregion

            //Adding Users
            #region

            if (!context.users.Any())
            {
                var userList = new List<User>()
                {
                    new User(){ UserName = "alican03",FirstName = "Alican",LastName = "Yilmaz",Email = "alicany@mail",Password = "1234"},
                    new User(){ UserName = "yilmaz03", FirstName = "Yilmaz", LastName = "Gelistirici",Email = "contact@alicanyilmaz", Password = "4321"}
                };
                userList.ForEach(user => context.users.Add(user));
                context.SaveChanges();
            }

            #endregion

            List<User> users = context.users.ToList();

            //Adding Roles
            #region

            if (!context.roles.Any())
            {
                var roleList = new List<Role>()
                {
                    new Role(){Name="Admin"},
                    new Role(){Name="Student"},
                    new Role(){Name="Editor"}
                };
                roleList.ForEach(role=>context.roles.Add(role));
                context.SaveChanges();
            }

            #endregion

            List<Role> roles = context.roles.ToList();

            //Adding UserRoles
            #region

            if (!context.userRoles.Any())
            {
                var userRolesList = new List<UserRoles>() 
                {
                    new UserRoles(){UserId=users[0].Id,RoleId=roles[1].Id},
                    new UserRoles(){UserId=users[1].Id,RoleId=roles[0].Id}

                };
                userRolesList.ForEach(userrole=>context.userRoles.Add(userrole));
                context.SaveChanges();
            }

            #endregion
        }
    }
}
