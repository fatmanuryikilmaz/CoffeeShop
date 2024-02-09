using FikaCoffeeShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FikaCoffeeShop.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1,CategoryId=1, Name = "Turkish Coffee", Price = 45, Stock = 100, CreatedDate = DateTime.Now, Image = "https://static.ticimax.cloud/2571/Uploads/Blog/Lezzetli-Turk-Kahvesinin-Tarifi-452e.jpg" },
                new Product { Id = 2, CategoryId = 2, Name = "Iced Americano", Price = 60, Stock = 107, CreatedDate = DateTime.Now, Image = "https://ideacdn.net/idea/li/11/myassets/blogs/blog-12.jpg?revision=1674215336" },
                new Product { Id = 3, CategoryId = 4, Name = "Profiterol", Price = 90, Stock = 50, CreatedDate = DateTime.Now, Image = "https://cdn.yemek.com/mnresize/940/940/uploads/2014/11/profiterol-yemekcom2.jpg" },
                new Product { Id = 4, CategoryId = 3, Name = "Hamburger", Price = 123, Stock = 10, CreatedDate = DateTime.Now, Image = "https://cdn.yemek.com/mnresize/940/940/uploads/2020/03/bby-citir-tabuk-yemekcomm.jpg" }
                );
        }
    }
}
