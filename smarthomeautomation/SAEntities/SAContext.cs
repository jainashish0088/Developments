using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    class SAContext:DbContext
    {
        protected SAContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<PaymentMode> PaymentModes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
