using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    class SAContext : DbContext
    {
        public SAContext()
            : base("name=SmartAutomationHomeDB")
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
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategoryRel> ProductCategoryRelations { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartDetail> ShoppingCartDetails { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<UserRoleRel> UserRoleRelations { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    }
}
