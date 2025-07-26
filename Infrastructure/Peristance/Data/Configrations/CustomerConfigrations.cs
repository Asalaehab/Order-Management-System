using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Peristance.Data.Configrations
{
    public class CustomerConfigrations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //throw new NotImplementedException();

            builder.HasKey(C=>C.CustomerId);

            builder.Property(C => C.Name)
                .HasColumnType("varchar(50)");
        }
    }
}
