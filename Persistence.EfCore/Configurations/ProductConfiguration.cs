using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EfCore.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.HasIndex(p => p.Name);
            builder.Property(p=> p.Price).IsRequired().HasColumnName("decimal(9,2)");
        }
    }
}
