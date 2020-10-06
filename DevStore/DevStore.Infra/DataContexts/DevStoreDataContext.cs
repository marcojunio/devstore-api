﻿using DevStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStore.Infra.DataContexts
{
   public class DevStoreDataContext : DbContext
    {
        public DevStoreDataContext() 
            : base("DevStoreConnectionString")
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
    }

    public class DevStoreDataContextInitializer : DropCreateDatabaseIfModelChanges<DevStoreDataContext> 
    {
        protected override void Seed(DevStoreDataContext context)
        {
            context.Categories.Add(new Category { Id = 1, Title = "Informática" });
            context.Categories.Add(new Category { Id = 2, Title = "Games" });
            context.Categories.Add(new Category { Id = 3, Title = "Papelaria" });
            context.SaveChanges();

            context.Products.Add(new Product { Id = 1, CategoryId = 1, IsActive = true, Title = "Mouse Microsoft Confort 5000", Price = 99 });
            context.Products.Add(new Product { Id = 2, CategoryId = 1, IsActive = true, Title = "Teclado Microsoft Confort 5000", Price = 199 });
            context.Products.Add(new Product { Id = 3, CategoryId = 1, IsActive = true, Title = "Mouse Pad Razer", Price = 59 });

            context.Products.Add(new Product { Id = 4, CategoryId = 2, IsActive = true, Title = "Gears of War", Price = 59 });
            context.Products.Add(new Product { Id = 5, CategoryId = 2, IsActive = true, Title = "Gears of War 2", Price = 79 });
            context.Products.Add(new Product { Id = 6, CategoryId = 2, IsActive = true, Title = "Gears of War 3", Price = 99 });

            context.Products.Add(new Product { Id = 7, CategoryId = 3, IsActive = true, Title = "Papel Sulfite 1000 folhas", Price = 9.89M });
            context.SaveChanges();

        }
    }
}
