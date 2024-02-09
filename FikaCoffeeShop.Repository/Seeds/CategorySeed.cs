using FikaCoffeeShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Cold Drinks" },
                new Category { Id = 2, Name = "Hot Drinks" },
                new Category { Id = 3, Name = "Hot Food" },
                new Category { Id = 4, Name = "Cold Food" }
                );
        }
    }
}
