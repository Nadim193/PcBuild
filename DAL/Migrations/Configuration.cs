﻿namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.PcBuildContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.PcBuildContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            for (int i =1; i <=5; i++) 
            {
                context.Sellers.AddOrUpdate(new Models.Seller
                {
                    Name =Guid.NewGuid().ToString().Substring(0,10),
                    Sname="Seller-"+i,
                    Password= Guid.NewGuid().ToString().Substring(0, 10),
                    PhoneNumber= Guid.NewGuid().ToString().Substring(0, 10),
                    Email= Guid.NewGuid().ToString().Substring(0, 10),
                    NidNumber= Guid.NewGuid().ToString().Substring(0, 10),

                });
            }
            Random random = new Random();
            for (int i= 1; i <=10; i++)
            {
                context.Products.AddOrUpdate(new Models.Product
                {
                    Id =i,
                    ProductName= Guid.NewGuid().ToString().Substring(0, 10),
                    ProdcutQuantity= random.Next(100, 500),
                    ProductCategory= Guid.NewGuid().ToString().Substring(0, 10),
                    ProductPrice= random.Next(10000, 50000),
                    SelleingBy="Seller-"+random.Next(1,6),
                });
            }

            for (int i= 1 ; i <=50 ; i++)
            {
                context.Orders.AddOrUpdate(new Models.Order
                {
                    Id =i,
                    OrderDate= DateTime.Now,
                    OrderType="Laptop",
                    OrderQuantity= Guid.NewGuid().ToString().Substring(0, 10),
                    Location= Guid.NewGuid().ToString().Substring(0, 10),
                    SelleBy="Seller-" + random.Next(1,6),
                    productby = random.Next(1,9),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Users.AddOrUpdate(new Models.User
                {
                    Id = i,
                    uname = Guid.NewGuid().ToString().Substring(0, 10),
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Email = Guid.NewGuid().ToString().Substring(0, 10),
                    PhoneNumber = random.Next(1, 6),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.UserOrders.AddOrUpdate(new Models.User_Order
                {
                    Id = i,
                    Oid = random.Next(1, 9),
                    Uid = random.Next(1, 49),
                    PaymentBy = Guid.NewGuid().ToString().Substring(0, 10),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Carts.AddOrUpdate(new Models.Cart
                {
                    Id = i,
                    uid = random.Next(1, 49),
                    pid = random.Next(1, 9),
                    Quantity = random.Next(1,15)
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.Reviews.AddOrUpdate(new Models.Review
                {
                    Id = i,
                    review = Guid.NewGuid().ToString().Substring(0, 10),
                    date = DateTime.Now,
                    uid = random.Next(1, 49),
                    pid = random.Next(1, 9),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.ProductOrders.AddOrUpdate(new Models.ProductOrder
                {
                    Id = i,
                    Oid = random.Next(1, 49),
                    pid = random.Next(1, 9),
                });
            }
            for (int i = 1; i <= 50; i++)
            {
                context.FeedBacks.AddOrUpdate(new Models.FeedBack
                {
                    Id = i,
                    Date = DateTime.Now,
                    ReviewFeedBack = Guid.NewGuid().ToString().Substring(0, 30),
                    rid = random.Next(1, 49),
                });
            }
        }
    }
}
