using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peristance.DbContexts
{
    public class OrderManagementSystemDbContext : DbContext
    {
        public OrderManagementSystemDbContext(DbContextOptions<OrderManagementSystemDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyRefernce).Assembly);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
