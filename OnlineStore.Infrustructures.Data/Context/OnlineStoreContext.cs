using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Infrustructures.Data.Context
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
