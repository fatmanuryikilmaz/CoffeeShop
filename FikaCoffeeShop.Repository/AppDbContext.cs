using FikaCoffeeShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FikaCoffeeShop.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



            modelBuilder.Entity<ProductFeature>().HasData(
           new ProductFeature()
           {
               Id = 1,
               Calorie = 100,
               ServingType = "450ml Cup",
               ProductId = 1
           },
           new ProductFeature() { 
           Id = 2,
               Calorie = 500,
               ServingType = "700ml Cup",
               ProductId = 2
           },
           new ProductFeature()
           {
               Id = 3,
               Calorie = 450,
               ServingType = "hot",
               ProductId = 3
           },
            new ProductFeature()
            {
                Id = 4,
                Calorie = 350,
                ServingType = "cold",
                ProductId = 4
            });




            base.OnModelCreating(modelBuilder); 
        }


    }
}
