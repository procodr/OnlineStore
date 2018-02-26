using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSite.Models.Context
{
    class WebSiteContext : DbContext
    {
        public WebSiteContext(DbContextOptions<WebSiteContext> options) : base(options)
        {
        }
        public DbSet<Cutomer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
