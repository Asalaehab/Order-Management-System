using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peristance.Data.Configrations
{
    public class ProductConfigrations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.ProductId)
                 .UseIdentityColumn(100, 100);

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.Name)
                .HasColumnType("varchar(20)");
        }
    }
}
