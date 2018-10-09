namespace SAEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SmartAutomationDb : DbContext
    {
        public SmartAutomationDb()
            : base("name=SmartAutomationDb")
        {
        }

        public virtual DbSet<T_CM_Address_Book> T_CM_Address_Book { get; set; }
        public virtual DbSet<T_CM_Customers> T_CM_Customers { get; set; }
        public virtual DbSet<T_MS_Brands> T_MS_Brands { get; set; }
        public virtual DbSet<T_MS_City> T_MS_City { get; set; }
        public virtual DbSet<T_MS_Country> T_MS_Country { get; set; }
        public virtual DbSet<T_MS_Coupon> T_MS_Coupon { get; set; }
        public virtual DbSet<T_MS_PaymentMode> T_MS_PaymentMode { get; set; }
        public virtual DbSet<T_MS_Product_Category> T_MS_Product_Category { get; set; }
        public virtual DbSet<T_MS_Products> T_MS_Products { get; set; }
        public virtual DbSet<T_MS_ROLE> T_MS_ROLE { get; set; }
        public virtual DbSet<T_MS_State> T_MS_State { get; set; }
        public virtual DbSet<T_MS_Supplier_Products> T_MS_Supplier_Products { get; set; }
        public virtual DbSet<T_MS_Suppliers> T_MS_Suppliers { get; set; }
        public virtual DbSet<T_MS_USER_ROLE> T_MS_USER_ROLE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_CM_Address_Book>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Address_Book>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Address_Book>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Address_Book>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Customers>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Customers>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Customers>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Customers>()
                .Property(e => e.EmailID)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Customers>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<T_CM_Customers>()
                .HasMany(e => e.T_CM_Address_Book)
                .WithRequired(e => e.T_CM_Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_CM_Customers>()
                .HasMany(e => e.T_MS_Suppliers)
                .WithRequired(e => e.T_CM_Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_CM_Customers>()
                .HasMany(e => e.T_MS_USER_ROLE)
                .WithRequired(e => e.T_CM_Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MS_Brands>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Brands>()
                .Property(e => e.BrandDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Brands>()
                .HasMany(e => e.T_MS_Products)
                .WithRequired(e => e.T_MS_Brands)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MS_City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_City>()
                .HasMany(e => e.T_CM_Address_Book)
                .WithRequired(e => e.T_MS_City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MS_Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Country>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Coupon>()
                .Property(e => e.CouponName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Coupon>()
                .Property(e => e.CouponCode)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Coupon>()
                .Property(e => e.CouponDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_PaymentMode>()
                .Property(e => e.PayName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_PaymentMode>()
                .Property(e => e.PayDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Product_Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Product_Category>()
                .Property(e => e.CategoryShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Product_Category>()
                .Property(e => e.CategoryDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Product_Category>()
                .Property(e => e.CategoryMetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Product_Category>()
                .Property(e => e.CategoryMetaDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Product_Category>()
                .Property(e => e.CategroyMetaKeywords)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Product_Category>()
                .HasMany(e => e.T_MS_Product_Category1)
                .WithOptional(e => e.T_MS_Product_Category2)
                .HasForeignKey(e => e.ParentCategory);

            modelBuilder.Entity<T_MS_Products>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Products>()
                .Property(e => e.ProductShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Products>()
                .Property(e => e.ProductDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Products>()
                .Property(e => e.ProductMetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Products>()
                .Property(e => e.ProductMetaDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Products>()
                .Property(e => e.ProductMetaKeyword)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Products>()
                .HasMany(e => e.T_MS_Supplier_Products)
                .WithRequired(e => e.T_MS_Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MS_ROLE>()
                .Property(e => e.RoleNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_ROLE>()
                .Property(e => e.RoleDESC)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_ROLE>()
                .HasMany(e => e.T_MS_USER_ROLE)
                .WithRequired(e => e.T_MS_ROLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MS_State>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_State>()
                .HasMany(e => e.T_MS_City)
                .WithRequired(e => e.T_MS_State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<T_MS_Supplier_Products>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Supplier_Products>()
                .Property(e => e.ProductShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Supplier_Products>()
                .Property(e => e.ProductDesc)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Supplier_Products>()
                .Property(e => e.SellingPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_MS_Supplier_Products>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_MS_Supplier_Products>()
                .Property(e => e.Discount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_MS_Supplier_Products>()
                .Property(e => e.Tax)
                .HasPrecision(18, 4);

            modelBuilder.Entity<T_MS_Suppliers>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Suppliers>()
                .Property(e => e.CompanyEmailID)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Suppliers>()
                .Property(e => e.CompanyContactNumber)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Suppliers>()
                .Property(e => e.CompanyFaxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<T_MS_Suppliers>()
                .Property(e => e.GSTNumber)
                .IsUnicode(false);
        }
    }
}
