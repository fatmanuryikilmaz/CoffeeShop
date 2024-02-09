﻿using FikaCoffeeShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Repository.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);

            builder.ToTable("Categories");
        }
    }
}
