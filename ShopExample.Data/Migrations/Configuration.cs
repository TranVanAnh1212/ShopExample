﻿namespace ShopExample.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ShopExample.Model.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopExample.Data.ShopExampleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopExample.Data.ShopExampleDBContext context)
        {
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopExampleDBContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopExampleDBContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "TranVanAnh",
            //    Email = "anh038953@gmail.com",
            //    Birthday = DateTime.Now,
            //    Fullname = "Trần Văn Anh đẹp trai"

            //};

            //manager.Create(user, "12345$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("anh038953@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

            CreateProductCategorySample(context);
            CreateProductSample(context);
        }

        private void CreateProductCategorySample(ShopExampleDBContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh", CreatedDate=DateTime.Now, Status=true },
                    new ProductCategory() { Name="Viễn thông",Alias="vien-thong", CreatedDate=DateTime.Now, Status=true },
                    new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung", CreatedDate=DateTime.Now, Status=true },
                    new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham", CreatedDate=DateTime.Now, Status=true }
                };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }

        }

        private void CreateProductSample(ShopExampleDBContext context)
        {
            if (context.Products.Count() == 0)
            {
                List<Product> listProd = new List<Product>()
                {
                    new Product() {ID = 231231, Name="IPhone 15 Pro Max 258GB", Alias="IPhone15, Apple, IPhone", CategoryID=5, Price=35990000, Origin="Apple", Quantity=165, CreatedDate=DateTime.Now, CreatedBy="TranVanAnh - Admin", },
                    new Product() {ID = 231231, Name="Samsung galaxy", Alias="samsung-galaxy, samsung", CategoryID=5, Price=2990000, Origin="SamSung", Quantity=15, CreatedDate=DateTime.Now, CreatedBy="TranVanAnh - Admin", },
                    new Product() {ID = 231231, Name="TV OSny", Alias="TV, Sony, TVSony", CategoryID=5, Price=12990000, Origin="Sony", Quantity=165, CreatedDate=DateTime.Now, CreatedBy="TranVanAnh - Admin", },
                };
                context.Products.AddRange(listProd);
                context.SaveChanges();
            }

        }

    }
}
