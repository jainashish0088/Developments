namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smarthomeautomation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                        Desc = c.String(maxLength: 2000),
                        LargeImg = c.String(maxLength: 200),
                        SmallImg = c.String(maxLength: 200),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 1000),
                        ProductCode = c.String(maxLength: 200),
                        ProductShortDesc = c.String(maxLength: 2000),
                        ProductDesc = c.String(),
                        Quantity = c.Int(nullable: false),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MRP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AllowReturn = c.Boolean(nullable: false),
                        ReturnDuration = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        ISDiscOnPercOrValue = c.Short(nullable: false),
                        Brand_Id = c.Int(),
                        Supplier_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.Brand_Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id)
                .Index(t => t.Brand_Id)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderId = c.Long(nullable: false),
                        ProductName = c.String(maxLength: 1000),
                        ProductCode = c.String(maxLength: 200),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MRP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentDetails",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        OrderDetail_Id = c.Long(),
                        Payment_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderDetails", t => t.OrderDetail_Id)
                .ForeignKey("dbo.Payments", t => t.Payment_Id)
                .Index(t => t.OrderDetail_Id)
                .Index(t => t.Payment_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderNumber = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Customer_Id = c.Long(),
                        PaymentMode_Id = c.Int(),
                        Payment_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.PaymentModes", t => t.PaymentMode_Id)
                .ForeignKey("dbo.Payments", t => t.Payment_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.PaymentMode_Id)
                .Index(t => t.Payment_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 200),
                        MiddleName = c.String(maxLength: 200),
                        LastName = c.String(maxLength: 200),
                        DateofBirth = c.DateTime(),
                        EmailID = c.String(maxLength: 500),
                        MobileNo = c.String(maxLength: 200),
                        IsActive = c.Boolean(nullable: false),
                        IsMobileVerified = c.Boolean(nullable: false),
                        IsEmailVerified = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Suppliers_Id = c.Long(),
                        UserTypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.Suppliers_Id)
                .ForeignKey("dbo.UserTypes", t => t.UserTypes_Id)
                .Index(t => t.EmailID, unique: true)
                .Index(t => t.MobileNo, unique: true)
                .Index(t => t.Suppliers_Id)
                .Index(t => t.UserTypes_Id);
            
            CreateTable(
                "dbo.AddressBooks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Address1 = c.String(nullable: false, maxLength: 500),
                        Address2 = c.String(maxLength: 500),
                        Address3 = c.String(maxLength: 500),
                        PostCode = c.String(nullable: false, maxLength: 20),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Cities_Id = c.Int(),
                        Customer_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.Cities_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Cities_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        State_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.State_Id)
                .Index(t => t.State_Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Code = c.String(nullable: false, maxLength: 10),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Customer_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.ShoppingCartDetails",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ShoppingCartId = c.Long(nullable: false),
                        ProductName = c.String(maxLength: 1000),
                        ProductCode = c.String(maxLength: 200),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MRP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsCancelled = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCartId, cascadeDelete: true)
                .Index(t => t.ShoppingCartId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                        EmailId = c.String(),
                        ContactNumber = c.String(),
                        CompanyFaxNumber = c.String(),
                        GSTNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoleRels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Customer_Id = c.Long(),
                        Role_Id = c.Int(),
                        UserType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.UserType_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Desc = c.String(maxLength: 200),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Desc = c.String(nullable: false, maxLength: 200),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentModes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PayName = c.String(maxLength: 200),
                        PayDesc = c.String(maxLength: 1000),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductCategoryRels",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CategoryId = c.Long(),
                        Name = c.String(nullable: false, maxLength: 2000),
                        ShortDesc = c.String(maxLength: 2000),
                        Desc = c.String(),
                        MetaTitle = c.String(maxLength: 2000),
                        MetaDesc = c.String(),
                        MetaKeywords = c.String(),
                        SmallImg = c.String(),
                        LargeImg = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        SequenceNumber = c.Long(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductGalleries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ProductID = c.Long(nullable: false),
                        GalleryName = c.String(maxLength: 500),
                        GalleryDesc = c.String(maxLength: 2000),
                        GalleryImg = c.String(maxLength: 2000),
                        ShowOnListing = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.ShoppingCartDetailProducts",
                c => new
                    {
                        ShoppingCartDetail_Id = c.Long(nullable: false),
                        Product_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCartDetail_Id, t.Product_Id })
                .ForeignKey("dbo.ShoppingCartDetails", t => t.ShoppingCartDetail_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.ShoppingCartDetail_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.OrderDetailProducts",
                c => new
                    {
                        OrderDetail_Id = c.Long(nullable: false),
                        Product_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderDetail_Id, t.Product_Id })
                .ForeignKey("dbo.OrderDetails", t => t.OrderDetail_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.OrderDetail_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.CategoryProductCategoryRels",
                c => new
                    {
                        Category_Id = c.Long(nullable: false),
                        ProductCategoryRel_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.ProductCategoryRel_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.ProductCategoryRels", t => t.ProductCategoryRel_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.ProductCategoryRel_Id);
            
            CreateTable(
                "dbo.ProductCategoryRelProducts",
                c => new
                    {
                        ProductCategoryRel_Id = c.Long(nullable: false),
                        Product_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductCategoryRel_Id, t.Product_Id })
                .ForeignKey("dbo.ProductCategoryRels", t => t.ProductCategoryRel_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.ProductCategoryRel_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductGalleries", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductCategoryRelProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductCategoryRelProducts", "ProductCategoryRel_Id", "dbo.ProductCategoryRels");
            DropForeignKey("dbo.CategoryProductCategoryRels", "ProductCategoryRel_Id", "dbo.ProductCategoryRels");
            DropForeignKey("dbo.CategoryProductCategoryRels", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.OrderDetailProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderDetailProducts", "OrderDetail_Id", "dbo.OrderDetails");
            DropForeignKey("dbo.PaymentDetails", "Payment_Id", "dbo.Payments");
            DropForeignKey("dbo.Orders", "Payment_Id", "dbo.Payments");
            DropForeignKey("dbo.Orders", "PaymentMode_Id", "dbo.PaymentModes");
            DropForeignKey("dbo.UserRoleRels", "UserType_Id", "dbo.UserTypes");
            DropForeignKey("dbo.Customers", "UserTypes_Id", "dbo.UserTypes");
            DropForeignKey("dbo.UserRoleRels", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserRoleRels", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Products", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.Customers", "Suppliers_Id", "dbo.Suppliers");
            DropForeignKey("dbo.ShoppingCartDetails", "ShoppingCartId", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCartDetailProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ShoppingCartDetailProducts", "ShoppingCartDetail_Id", "dbo.ShoppingCartDetails");
            DropForeignKey("dbo.ShoppingCarts", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.AddressBooks", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.States", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Cities", "State_Id", "dbo.States");
            DropForeignKey("dbo.AddressBooks", "Cities_Id", "dbo.Cities");
            DropForeignKey("dbo.PaymentDetails", "OrderDetail_Id", "dbo.OrderDetails");
            DropForeignKey("dbo.Products", "Brand_Id", "dbo.Brands");
            DropIndex("dbo.ProductCategoryRelProducts", new[] { "Product_Id" });
            DropIndex("dbo.ProductCategoryRelProducts", new[] { "ProductCategoryRel_Id" });
            DropIndex("dbo.CategoryProductCategoryRels", new[] { "ProductCategoryRel_Id" });
            DropIndex("dbo.CategoryProductCategoryRels", new[] { "Category_Id" });
            DropIndex("dbo.OrderDetailProducts", new[] { "Product_Id" });
            DropIndex("dbo.OrderDetailProducts", new[] { "OrderDetail_Id" });
            DropIndex("dbo.ShoppingCartDetailProducts", new[] { "Product_Id" });
            DropIndex("dbo.ShoppingCartDetailProducts", new[] { "ShoppingCartDetail_Id" });
            DropIndex("dbo.ProductGalleries", new[] { "ProductID" });
            DropIndex("dbo.UserRoleRels", new[] { "UserType_Id" });
            DropIndex("dbo.UserRoleRels", new[] { "Role_Id" });
            DropIndex("dbo.UserRoleRels", new[] { "Customer_Id" });
            DropIndex("dbo.ShoppingCartDetails", new[] { "ShoppingCartId" });
            DropIndex("dbo.ShoppingCarts", new[] { "Customer_Id" });
            DropIndex("dbo.States", new[] { "Country_Id" });
            DropIndex("dbo.Cities", new[] { "State_Id" });
            DropIndex("dbo.AddressBooks", new[] { "Customer_Id" });
            DropIndex("dbo.AddressBooks", new[] { "Cities_Id" });
            DropIndex("dbo.Customers", new[] { "UserTypes_Id" });
            DropIndex("dbo.Customers", new[] { "Suppliers_Id" });
            DropIndex("dbo.Customers", new[] { "MobileNo" });
            DropIndex("dbo.Customers", new[] { "EmailID" });
            DropIndex("dbo.Orders", new[] { "Payment_Id" });
            DropIndex("dbo.Orders", new[] { "PaymentMode_Id" });
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropIndex("dbo.PaymentDetails", new[] { "Payment_Id" });
            DropIndex("dbo.PaymentDetails", new[] { "OrderDetail_Id" });
            DropIndex("dbo.Products", new[] { "Supplier_Id" });
            DropIndex("dbo.Products", new[] { "Brand_Id" });
            DropTable("dbo.ProductCategoryRelProducts");
            DropTable("dbo.CategoryProductCategoryRels");
            DropTable("dbo.OrderDetailProducts");
            DropTable("dbo.ShoppingCartDetailProducts");
            DropTable("dbo.ProductGalleries");
            DropTable("dbo.Categories");
            DropTable("dbo.ProductCategoryRels");
            DropTable("dbo.PaymentModes");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Roles");
            DropTable("dbo.UserRoleRels");
            DropTable("dbo.Suppliers");
            DropTable("dbo.ShoppingCartDetails");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.Countries");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
            DropTable("dbo.AddressBooks");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Payments");
            DropTable("dbo.PaymentDetails");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}
