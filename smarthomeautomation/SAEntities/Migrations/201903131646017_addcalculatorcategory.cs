namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addcalculatorcategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Brand_Id", "dbo.Brands");
            DropForeignKey("dbo.AddressBooks", "Cities_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "State_Id", "dbo.States");
            DropForeignKey("dbo.States", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.UserRoleRels", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Customers", "UserTypes_Id", "dbo.UserTypes");
            DropForeignKey("dbo.UserRoleRels", "UserType_Id", "dbo.UserTypes");
            DropForeignKey("dbo.Orders", "PaymentMode_Id", "dbo.PaymentModes");
            DropIndex("dbo.Products", new[] { "Brand_Id" });
            DropIndex("dbo.Orders", new[] { "PaymentMode_Id" });
            DropIndex("dbo.Customers", new[] { "UserTypes_Id" });
            DropIndex("dbo.AddressBooks", new[] { "Cities_Id" });
            DropIndex("dbo.Cities", new[] { "State_Id" });
            DropIndex("dbo.States", new[] { "Country_Id" });
            DropIndex("dbo.UserRoleRels", new[] { "Role_Id" });
            DropIndex("dbo.UserRoleRels", new[] { "UserType_Id" });
            DropPrimaryKey("dbo.Brands");
            DropPrimaryKey("dbo.Cities");
            DropPrimaryKey("dbo.States");
            DropPrimaryKey("dbo.Countries");
            DropPrimaryKey("dbo.UserRoleRels");
            DropPrimaryKey("dbo.Roles");
            DropPrimaryKey("dbo.UserTypes");
            DropPrimaryKey("dbo.PaymentModes");
            CreateTable(
                "dbo.CalulatorCategories",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Name = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                    UpdatedDate = c.DateTime(),
                    IsActive = c.Boolean(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.CategoryCalulatorCategories",
                c => new
                {
                    Category_Id = c.Long(nullable: false),
                    CalulatorCategory_Id = c.Long(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    UpdatedDate = c.DateTime(),
                    IsActive = c.Boolean(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => new { t.Category_Id, t.CalulatorCategory_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.CalulatorCategories", t => t.CalulatorCategory_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.CalulatorCategory_Id);

            CreateTable(
                "dbo.CalulatorCategoryProducts",
                c => new
                {
                    CalulatorCategory_Id = c.Long(nullable: false),
                    Product_Id = c.Long(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    UpdatedDate = c.DateTime(),
                    IsActive = c.Boolean(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => new { t.CalulatorCategory_Id, t.Product_Id })
                .ForeignKey("dbo.CalulatorCategories", t => t.CalulatorCategory_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.CalulatorCategory_Id)
                .Index(t => t.Product_Id);

            AddColumn("dbo.OrderDetails", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderDetails", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.PaymentDetails", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.PaymentDetails", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Payments", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Payments", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ShoppingCarts", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ShoppingCarts", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ShoppingCartDetails", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ShoppingCartDetails", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserTypes", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserTypes", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Brands", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Products", "Brand_Id", c => c.Long());
            AlterColumn("dbo.Orders", "PaymentMode_Id", c => c.Long());
            AlterColumn("dbo.Customers", "UserTypes_Id", c => c.Long());
            AlterColumn("dbo.AddressBooks", "Cities_Id", c => c.Long());
            AlterColumn("dbo.Cities", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Cities", "State_Id", c => c.Long());
            AlterColumn("dbo.States", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.States", "Country_Id", c => c.Long());
            AlterColumn("dbo.Countries", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.UserRoleRels", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.UserRoleRels", "Role_Id", c => c.Long());
            AlterColumn("dbo.UserRoleRels", "UserType_Id", c => c.Long());
            AlterColumn("dbo.Roles", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.UserTypes", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.PaymentModes", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.ProductGalleries", "CreatedDate", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Brands", "Id");
            AddPrimaryKey("dbo.Cities", "Id");
            AddPrimaryKey("dbo.States", "Id");
            AddPrimaryKey("dbo.Countries", "Id");
            AddPrimaryKey("dbo.UserRoleRels", "Id");
            AddPrimaryKey("dbo.Roles", "Id");
            AddPrimaryKey("dbo.UserTypes", "Id");
            AddPrimaryKey("dbo.PaymentModes", "Id");
            CreateIndex("dbo.Products", "Brand_Id");
            CreateIndex("dbo.Orders", "PaymentMode_Id");
            CreateIndex("dbo.Customers", "UserTypes_Id");
            CreateIndex("dbo.AddressBooks", "Cities_Id");
            CreateIndex("dbo.Cities", "State_Id");
            CreateIndex("dbo.States", "Country_Id");
            CreateIndex("dbo.UserRoleRels", "Role_Id");
            CreateIndex("dbo.UserRoleRels", "UserType_Id");
            AddForeignKey("dbo.Products", "Brand_Id", "dbo.Brands", "Id");
            AddForeignKey("dbo.AddressBooks", "Cities_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Cities", "State_Id", "dbo.States", "Id");
            AddForeignKey("dbo.States", "Country_Id", "dbo.Countries", "Id");
            AddForeignKey("dbo.UserRoleRels", "Role_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.Customers", "UserTypes_Id", "dbo.UserTypes", "Id");
            AddForeignKey("dbo.UserRoleRels", "UserType_Id", "dbo.UserTypes", "Id");
            AddForeignKey("dbo.Orders", "PaymentMode_Id", "dbo.PaymentModes", "Id");
            CreateStoredProcedure(
                "dbo.CalulatorCategory_Insert",
                p => new
                {
                    Name = p.String(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[CalulatorCategories]([Name], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@Name, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[CalulatorCategories]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[CalulatorCategories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            CreateStoredProcedure(
                "dbo.CalulatorCategory_Update",
                p => new
                {
                    Id = p.Long(),
                    Name = p.String(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[CalulatorCategories]
                      SET [Name] = @Name, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[CalulatorCategories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            CreateStoredProcedure(
                "dbo.CalulatorCategory_Delete",
                p => new
                {
                    Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[CalulatorCategories]
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.Brand_Insert",
                p => new
                {
                    Name = p.String(maxLength: 200),
                    Desc = p.String(maxLength: 2000),
                    LargeImg = p.String(maxLength: 200),
                    SmallImg = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[Brands]([Name], [Desc], [LargeImg], [SmallImg], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@Name, @Desc, @LargeImg, @SmallImg, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Brands]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Brands] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Brand_Update",
                p => new
                {
                    Id = p.Long(),
                    Name = p.String(maxLength: 200),
                    Desc = p.String(maxLength: 2000),
                    LargeImg = p.String(maxLength: 200),
                    SmallImg = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[Brands]
                      SET [Name] = @Name, [Desc] = @Desc, [LargeImg] = @LargeImg, [SmallImg] = @SmallImg, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Brands] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Brand_Delete",
                p => new
                {
                    Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[Brands]
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.Product_Insert",
                p => new
                {
                    ProductName = p.String(maxLength: 1000),
                    NameForCalculator = p.String(maxLength: 1000),
                    ProductCode = p.String(maxLength: 200),
                    ProductShortDesc = p.String(maxLength: 2000),
                    ProductDesc = p.String(),
                    Quantity = p.Int(),
                    SellingPrice = p.Decimal(precision: 18, scale: 2),
                    MRP = p.Decimal(precision: 18, scale: 2),
                    Discount = p.Decimal(precision: 18, scale: 2),
                    Tax = p.Decimal(precision: 18, scale: 2),
                    AllowReturn = p.Boolean(),
                    ReturnDuration = p.Int(),
                    ISDiscOnPercOrValue = p.Short(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Brand_Id = p.Long(),
                    Supplier_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[Products]([ProductName], [NameForCalculator], [ProductCode], [ProductShortDesc], [ProductDesc], [Quantity], [SellingPrice], [MRP], [Discount], [Tax], [AllowReturn], [ReturnDuration], [ISDiscOnPercOrValue], [UpdatedDate], [IsActive], [IsDeleted], [Brand_Id], [Supplier_Id])
                      VALUES (@ProductName, @NameForCalculator, @ProductCode, @ProductShortDesc, @ProductDesc, @Quantity, @SellingPrice, @MRP, @Discount, @Tax, @AllowReturn, @ReturnDuration, @ISDiscOnPercOrValue, @UpdatedDate, @IsActive, @IsDeleted, @Brand_Id, @Supplier_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Products]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Products] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Product_Update",
                p => new
                {
                    Id = p.Long(),
                    ProductName = p.String(maxLength: 1000),
                    NameForCalculator = p.String(maxLength: 1000),
                    ProductCode = p.String(maxLength: 200),
                    ProductShortDesc = p.String(maxLength: 2000),
                    ProductDesc = p.String(),
                    Quantity = p.Int(),
                    SellingPrice = p.Decimal(precision: 18, scale: 2),
                    MRP = p.Decimal(precision: 18, scale: 2),
                    Discount = p.Decimal(precision: 18, scale: 2),
                    Tax = p.Decimal(precision: 18, scale: 2),
                    AllowReturn = p.Boolean(),
                    ReturnDuration = p.Int(),
                    ISDiscOnPercOrValue = p.Short(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Brand_Id = p.Long(),
                    Supplier_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[Products]
                      SET [ProductName] = @ProductName, [NameForCalculator] = @NameForCalculator, [ProductCode] = @ProductCode, [ProductShortDesc] = @ProductShortDesc, [ProductDesc] = @ProductDesc, [Quantity] = @Quantity, [SellingPrice] = @SellingPrice, [MRP] = @MRP, [Discount] = @Discount, [Tax] = @Tax, [AllowReturn] = @AllowReturn, [ReturnDuration] = @ReturnDuration, [ISDiscOnPercOrValue] = @ISDiscOnPercOrValue, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [Brand_Id] = @Brand_Id, [Supplier_Id] = @Supplier_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Products] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Product_Delete",
                p => new
                {
                    Id = p.Long(),
                    Brand_Id = p.Long(),
                    Supplier_Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[Products]
                      WHERE ((([Id] = @Id) AND (([Brand_Id] = @Brand_Id) OR ([Brand_Id] IS NULL AND @Brand_Id IS NULL))) AND (([Supplier_Id] = @Supplier_Id) OR ([Supplier_Id] IS NULL AND @Supplier_Id IS NULL)))"
            );

            AlterStoredProcedure(
                "dbo.Category_Insert",
                p => new
                {
                    CategoryId = p.Long(),
                    Name = p.String(maxLength: 2000),
                    ShortDesc = p.String(maxLength: 2000),
                    Desc = p.String(),
                    MetaTitle = p.String(maxLength: 2000),
                    MetaDesc = p.String(),
                    MetaKeywords = p.String(),
                    SmallImg = p.String(),
                    LargeImg = p.String(),
                    SequenceNumber = p.Long(),
                    IsShowOnCalculator = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[Categories]([CategoryId], [Name], [ShortDesc], [Desc], [MetaTitle], [MetaDesc], [MetaKeywords], [SmallImg], [LargeImg], [SequenceNumber], [IsShowOnCalculator], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@CategoryId, @Name, @ShortDesc, @Desc, @MetaTitle, @MetaDesc, @MetaKeywords, @SmallImg, @LargeImg, @SequenceNumber, @IsShowOnCalculator, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Categories]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Categories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Category_Update",
                p => new
                {
                    Id = p.Long(),
                    CategoryId = p.Long(),
                    Name = p.String(maxLength: 2000),
                    ShortDesc = p.String(maxLength: 2000),
                    Desc = p.String(),
                    MetaTitle = p.String(maxLength: 2000),
                    MetaDesc = p.String(),
                    MetaKeywords = p.String(),
                    SmallImg = p.String(),
                    LargeImg = p.String(),
                    SequenceNumber = p.Long(),
                    IsShowOnCalculator = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[Categories]
                      SET [CategoryId] = @CategoryId, [Name] = @Name, [ShortDesc] = @ShortDesc, [Desc] = @Desc, [MetaTitle] = @MetaTitle, [MetaDesc] = @MetaDesc, [MetaKeywords] = @MetaKeywords, [SmallImg] = @SmallImg, [LargeImg] = @LargeImg, [SequenceNumber] = @SequenceNumber, [IsShowOnCalculator] = @IsShowOnCalculator, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Categories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.OrderDetail_Insert",
                p => new
                {
                    OrderId = p.Long(),
                    ProductName = p.String(maxLength: 1000),
                    ProductCode = p.String(maxLength: 200),
                    SellingPrice = p.Decimal(precision: 18, scale: 2),
                    MRP = p.Decimal(precision: 18, scale: 2),
                    Discount = p.Decimal(precision: 18, scale: 2),
                    Tax = p.Decimal(precision: 18, scale: 2),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[OrderDetails]([OrderId], [ProductName], [ProductCode], [SellingPrice], [MRP], [Discount], [Tax], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@OrderId, @ProductName, @ProductCode, @SellingPrice, @MRP, @Discount, @Tax, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[OrderDetails]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[OrderDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.OrderDetail_Update",
                p => new
                {
                    Id = p.Long(),
                    OrderId = p.Long(),
                    ProductName = p.String(maxLength: 1000),
                    ProductCode = p.String(maxLength: 200),
                    SellingPrice = p.Decimal(precision: 18, scale: 2),
                    MRP = p.Decimal(precision: 18, scale: 2),
                    Discount = p.Decimal(precision: 18, scale: 2),
                    Tax = p.Decimal(precision: 18, scale: 2),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[OrderDetails]
                      SET [OrderId] = @OrderId, [ProductName] = @ProductName, [ProductCode] = @ProductCode, [SellingPrice] = @SellingPrice, [MRP] = @MRP, [Discount] = @Discount, [Tax] = @Tax, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[OrderDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.PaymentDetail_Insert",
                p => new
                {
                    Amount = p.Decimal(precision: 18, scale: 2),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    OrderDetail_Id = p.Long(),
                    Payment_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[PaymentDetails]([Amount], [UpdatedDate], [IsActive], [IsDeleted], [OrderDetail_Id], [Payment_Id])
                      VALUES (@Amount, @UpdatedDate, @IsActive, @IsDeleted, @OrderDetail_Id, @Payment_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[PaymentDetails]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[PaymentDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.PaymentDetail_Update",
                p => new
                {
                    Id = p.Long(),
                    Amount = p.Decimal(precision: 18, scale: 2),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    OrderDetail_Id = p.Long(),
                    Payment_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[PaymentDetails]
                      SET [Amount] = @Amount, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [OrderDetail_Id] = @OrderDetail_Id, [Payment_Id] = @Payment_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[PaymentDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Payment_Insert",
                p => new
                {
                    Amount = p.Decimal(precision: 18, scale: 2),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[Payments]([Amount], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@Amount, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Payments]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Payments] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Payment_Update",
                p => new
                {
                    Id = p.Long(),
                    Amount = p.Decimal(precision: 18, scale: 2),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[Payments]
                      SET [Amount] = @Amount, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Payments] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Order_Insert",
                p => new
                {
                    TotalPrice = p.Decimal(precision: 18, scale: 2),
                    TotalDiscount = p.Decimal(precision: 18, scale: 2),
                    TotalTax = p.Decimal(precision: 18, scale: 2),
                    OrderNumber = p.String(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Customer_Id = p.Long(),
                    PaymentMode_Id = p.Long(),
                    Payment_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[Orders]([TotalPrice], [TotalDiscount], [TotalTax], [OrderNumber], [UpdatedDate], [IsActive], [IsDeleted], [Customer_Id], [PaymentMode_Id], [Payment_Id])
                      VALUES (@TotalPrice, @TotalDiscount, @TotalTax, @OrderNumber, @UpdatedDate, @IsActive, @IsDeleted, @Customer_Id, @PaymentMode_Id, @Payment_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Orders]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Orders] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Order_Update",
                p => new
                {
                    Id = p.Long(),
                    TotalPrice = p.Decimal(precision: 18, scale: 2),
                    TotalDiscount = p.Decimal(precision: 18, scale: 2),
                    TotalTax = p.Decimal(precision: 18, scale: 2),
                    OrderNumber = p.String(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Customer_Id = p.Long(),
                    PaymentMode_Id = p.Long(),
                    Payment_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[Orders]
                      SET [TotalPrice] = @TotalPrice, [TotalDiscount] = @TotalDiscount, [TotalTax] = @TotalTax, [OrderNumber] = @OrderNumber, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [Customer_Id] = @Customer_Id, [PaymentMode_Id] = @PaymentMode_Id, [Payment_Id] = @Payment_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Orders] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Order_Delete",
                p => new
                {
                    Id = p.Long(),
                    Customer_Id = p.Long(),
                    PaymentMode_Id = p.Long(),
                    Payment_Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[Orders]
                      WHERE (((([Id] = @Id) AND (([Customer_Id] = @Customer_Id) OR ([Customer_Id] IS NULL AND @Customer_Id IS NULL))) AND (([PaymentMode_Id] = @PaymentMode_Id) OR ([PaymentMode_Id] IS NULL AND @PaymentMode_Id IS NULL))) AND (([Payment_Id] = @Payment_Id) OR ([Payment_Id] IS NULL AND @Payment_Id IS NULL)))"
            );

            AlterStoredProcedure(
                "dbo.Customer_Insert",
                p => new
                {
                    FirstName = p.String(maxLength: 200),
                    MiddleName = p.String(maxLength: 200),
                    LastName = p.String(maxLength: 200),
                    DateofBirth = p.DateTime(),
                    EmailID = p.String(maxLength: 500),
                    MobileNo = p.String(maxLength: 200),
                    IsMobileVerified = p.Boolean(),
                    IsEmailVerified = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Suppliers_Id = p.Long(),
                    UserTypes_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[Customers]([FirstName], [MiddleName], [LastName], [DateofBirth], [EmailID], [MobileNo], [IsMobileVerified], [IsEmailVerified], [UpdatedDate], [IsActive], [IsDeleted], [Suppliers_Id], [UserTypes_Id])
                      VALUES (@FirstName, @MiddleName, @LastName, @DateofBirth, @EmailID, @MobileNo, @IsMobileVerified, @IsEmailVerified, @UpdatedDate, @IsActive, @IsDeleted, @Suppliers_Id, @UserTypes_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Customers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Customers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Customer_Update",
                p => new
                {
                    Id = p.Long(),
                    FirstName = p.String(maxLength: 200),
                    MiddleName = p.String(maxLength: 200),
                    LastName = p.String(maxLength: 200),
                    DateofBirth = p.DateTime(),
                    EmailID = p.String(maxLength: 500),
                    MobileNo = p.String(maxLength: 200),
                    IsMobileVerified = p.Boolean(),
                    IsEmailVerified = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Suppliers_Id = p.Long(),
                    UserTypes_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[Customers]
                      SET [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, [DateofBirth] = @DateofBirth, [EmailID] = @EmailID, [MobileNo] = @MobileNo, [IsMobileVerified] = @IsMobileVerified, [IsEmailVerified] = @IsEmailVerified, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [Suppliers_Id] = @Suppliers_Id, [UserTypes_Id] = @UserTypes_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Customers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Customer_Delete",
                p => new
                {
                    Id = p.Long(),
                    Suppliers_Id = p.Long(),
                    UserTypes_Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[Customers]
                      WHERE ((([Id] = @Id) AND (([Suppliers_Id] = @Suppliers_Id) OR ([Suppliers_Id] IS NULL AND @Suppliers_Id IS NULL))) AND (([UserTypes_Id] = @UserTypes_Id) OR ([UserTypes_Id] IS NULL AND @UserTypes_Id IS NULL)))"
            );

            AlterStoredProcedure(
                "dbo.AddressBook_Insert",
                p => new
                {
                    Address1 = p.String(maxLength: 500),
                    Address2 = p.String(maxLength: 500),
                    Address3 = p.String(maxLength: 500),
                    PostCode = p.String(maxLength: 20),
                    UpdatedDate = p.DateTime(),
                    Cities_Id = p.Long(),
                    Customer_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[AddressBooks]([Address1], [Address2], [Address3], [PostCode], [UpdatedDate], [Cities_Id], [Customer_Id])
                      VALUES (@Address1, @Address2, @Address3, @PostCode, @UpdatedDate, @Cities_Id, @Customer_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[AddressBooks]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[AddressBooks] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.AddressBook_Update",
                p => new
                {
                    Id = p.Long(),
                    Address1 = p.String(maxLength: 500),
                    Address2 = p.String(maxLength: 500),
                    Address3 = p.String(maxLength: 500),
                    PostCode = p.String(maxLength: 20),
                    UpdatedDate = p.DateTime(),
                    Cities_Id = p.Long(),
                    Customer_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[AddressBooks]
                      SET [Address1] = @Address1, [Address2] = @Address2, [Address3] = @Address3, [PostCode] = @PostCode, [UpdatedDate] = @UpdatedDate, [Cities_Id] = @Cities_Id, [Customer_Id] = @Customer_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[AddressBooks] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.AddressBook_Delete",
                p => new
                {
                    Id = p.Long(),
                    Cities_Id = p.Long(),
                    Customer_Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[AddressBooks]
                      WHERE ((([Id] = @Id) AND (([Cities_Id] = @Cities_Id) OR ([Cities_Id] IS NULL AND @Cities_Id IS NULL))) AND (([Customer_Id] = @Customer_Id) OR ([Customer_Id] IS NULL AND @Customer_Id IS NULL)))"
            );

            AlterStoredProcedure(
                "dbo.City_Insert",
                p => new
                {
                    Name = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    State_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[Cities]([Name], [UpdatedDate], [IsActive], [IsDeleted], [State_Id])
                      VALUES (@Name, @UpdatedDate, @IsActive, @IsDeleted, @State_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Cities]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Cities] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.City_Update",
                p => new
                {
                    Id = p.Long(),
                    Name = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    State_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[Cities]
                      SET [Name] = @Name, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [State_Id] = @State_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Cities] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.City_Delete",
                p => new
                {
                    Id = p.Long(),
                    State_Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[Cities]
                      WHERE (([Id] = @Id) AND (([State_Id] = @State_Id) OR ([State_Id] IS NULL AND @State_Id IS NULL)))"
            );

            AlterStoredProcedure(
                "dbo.State_Insert",
                p => new
                {
                    Name = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Country_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[States]([Name], [UpdatedDate], [IsActive], [IsDeleted], [Country_Id])
                      VALUES (@Name, @UpdatedDate, @IsActive, @IsDeleted, @Country_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[States]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[States] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.State_Update",
                p => new
                {
                    Id = p.Long(),
                    Name = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Country_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[States]
                      SET [Name] = @Name, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [Country_Id] = @Country_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[States] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.State_Delete",
                p => new
                {
                    Id = p.Long(),
                    Country_Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[States]
                      WHERE (([Id] = @Id) AND (([Country_Id] = @Country_Id) OR ([Country_Id] IS NULL AND @Country_Id IS NULL)))"
            );

            AlterStoredProcedure(
                "dbo.Country_Insert",
                p => new
                {
                    Name = p.String(maxLength: 200),
                    Code = p.String(maxLength: 10),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[Countries]([Name], [Code], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@Name, @Code, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Countries]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Countries] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Country_Update",
                p => new
                {
                    Id = p.Long(),
                    Name = p.String(maxLength: 200),
                    Code = p.String(maxLength: 10),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[Countries]
                      SET [Name] = @Name, [Code] = @Code, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Countries] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Country_Delete",
                p => new
                {
                    Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[Countries]
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.ShoppingCart_Insert",
                p => new
                {
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Customer_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[ShoppingCarts]([UpdatedDate], [IsActive], [IsDeleted], [Customer_Id])
                      VALUES (@UpdatedDate, @IsActive, @IsDeleted, @Customer_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[ShoppingCarts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[ShoppingCarts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.ShoppingCart_Update",
                p => new
                {
                    Id = p.Long(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Customer_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[ShoppingCarts]
                      SET [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [Customer_Id] = @Customer_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[ShoppingCarts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.ShoppingCartDetail_Insert",
                p => new
                {
                    ShoppingCartId = p.Long(),
                    ProductName = p.String(maxLength: 1000),
                    ProductCode = p.String(maxLength: 200),
                    SellingPrice = p.Decimal(precision: 18, scale: 2),
                    MRP = p.Decimal(precision: 18, scale: 2),
                    Discount = p.Decimal(precision: 18, scale: 2),
                    Tax = p.Decimal(precision: 18, scale: 2),
                    IsCancelled = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[ShoppingCartDetails]([ShoppingCartId], [ProductName], [ProductCode], [SellingPrice], [MRP], [Discount], [Tax], [IsCancelled], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@ShoppingCartId, @ProductName, @ProductCode, @SellingPrice, @MRP, @Discount, @Tax, @IsCancelled, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[ShoppingCartDetails]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[ShoppingCartDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.ShoppingCartDetail_Update",
                p => new
                {
                    Id = p.Long(),
                    ShoppingCartId = p.Long(),
                    ProductName = p.String(maxLength: 1000),
                    ProductCode = p.String(maxLength: 200),
                    SellingPrice = p.Decimal(precision: 18, scale: 2),
                    MRP = p.Decimal(precision: 18, scale: 2),
                    Discount = p.Decimal(precision: 18, scale: 2),
                    Tax = p.Decimal(precision: 18, scale: 2),
                    IsCancelled = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[ShoppingCartDetails]
                      SET [ShoppingCartId] = @ShoppingCartId, [ProductName] = @ProductName, [ProductCode] = @ProductCode, [SellingPrice] = @SellingPrice, [MRP] = @MRP, [Discount] = @Discount, [Tax] = @Tax, [IsCancelled] = @IsCancelled, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[ShoppingCartDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Supplier_Insert",
                p => new
                {
                    CompanyName = p.String(),
                    EmailId = p.String(maxLength: 500),
                    ContactNumber = p.String(maxLength: 200),
                    CompanyFaxNumber = p.String(),
                    GSTNumber = p.String(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[Suppliers]([CompanyName], [EmailId], [ContactNumber], [CompanyFaxNumber], [GSTNumber], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@CompanyName, @EmailId, @ContactNumber, @CompanyFaxNumber, @GSTNumber, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Suppliers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Suppliers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Supplier_Update",
                p => new
                {
                    Id = p.Long(),
                    CompanyName = p.String(),
                    EmailId = p.String(maxLength: 500),
                    ContactNumber = p.String(maxLength: 200),
                    CompanyFaxNumber = p.String(),
                    GSTNumber = p.String(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[Suppliers]
                      SET [CompanyName] = @CompanyName, [EmailId] = @EmailId, [ContactNumber] = @ContactNumber, [CompanyFaxNumber] = @CompanyFaxNumber, [GSTNumber] = @GSTNumber, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Suppliers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.UserRoleRel_Insert",
                p => new
                {
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Customer_Id = p.Long(),
                    Role_Id = p.Long(),
                    UserType_Id = p.Long(),
                },
                body:
                    @"INSERT [dbo].[UserRoleRels]([UpdatedDate], [IsActive], [IsDeleted], [Customer_Id], [Role_Id], [UserType_Id])
                      VALUES (@UpdatedDate, @IsActive, @IsDeleted, @Customer_Id, @Role_Id, @UserType_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[UserRoleRels]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[UserRoleRels] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.UserRoleRel_Update",
                p => new
                {
                    Id = p.Long(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                    Customer_Id = p.Long(),
                    Role_Id = p.Long(),
                    UserType_Id = p.Long(),
                },
                body:
                    @"UPDATE [dbo].[UserRoleRels]
                      SET [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [Customer_Id] = @Customer_Id, [Role_Id] = @Role_Id, [UserType_Id] = @UserType_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[UserRoleRels] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.UserRoleRel_Delete",
                p => new
                {
                    Id = p.Long(),
                    Customer_Id = p.Long(),
                    Role_Id = p.Long(),
                    UserType_Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[UserRoleRels]
                      WHERE (((([Id] = @Id) AND (([Customer_Id] = @Customer_Id) OR ([Customer_Id] IS NULL AND @Customer_Id IS NULL))) AND (([Role_Id] = @Role_Id) OR ([Role_Id] IS NULL AND @Role_Id IS NULL))) AND (([UserType_Id] = @UserType_Id) OR ([UserType_Id] IS NULL AND @UserType_Id IS NULL)))"
            );

            AlterStoredProcedure(
                "dbo.Role_Insert",
                p => new
                {
                    Name = p.String(maxLength: 30),
                    Desc = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[Roles]([Name], [Desc], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@Name, @Desc, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Roles]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Roles] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Role_Update",
                p => new
                {
                    Id = p.Long(),
                    Name = p.String(maxLength: 30),
                    Desc = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[Roles]
                      SET [Name] = @Name, [Desc] = @Desc, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Roles] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.Role_Delete",
                p => new
                {
                    Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[Roles]
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.UserType_Insert",
                p => new
                {
                    Name = p.String(maxLength: 50),
                    Desc = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[UserTypes]([Name], [Desc], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@Name, @Desc, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[UserTypes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[UserTypes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.UserType_Update",
                p => new
                {
                    Id = p.Long(),
                    Name = p.String(maxLength: 50),
                    Desc = p.String(maxLength: 200),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[UserTypes]
                      SET [Name] = @Name, [Desc] = @Desc, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[UserTypes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.UserType_Delete",
                p => new
                {
                    Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[UserTypes]
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.PaymentMode_Insert",
                p => new
                {
                    PayName = p.String(maxLength: 200),
                    PayDesc = p.String(maxLength: 1000),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[PaymentModes]([PayName], [PayDesc], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@PayName, @PayDesc, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[PaymentModes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[PaymentModes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.PaymentMode_Update",
                p => new
                {
                    Id = p.Long(),
                    PayName = p.String(maxLength: 200),
                    PayDesc = p.String(maxLength: 1000),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[PaymentModes]
                      SET [PayName] = @PayName, [PayDesc] = @PayDesc, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[PaymentModes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.PaymentMode_Delete",
                p => new
                {
                    Id = p.Long(),
                },
                body:
                    @"DELETE [dbo].[PaymentModes]
                      WHERE ([Id] = @Id)"
            );

            AlterStoredProcedure(
                "dbo.ProductGallery_Insert",
                p => new
                {
                    ProductID = p.Long(),
                    GalleryName = p.String(maxLength: 500),
                    GalleryDesc = p.String(maxLength: 2000),
                    GalleryImg = p.String(maxLength: 2000),
                    ShowOnListing = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"INSERT [dbo].[ProductGalleries]([ProductID], [GalleryName], [GalleryDesc], [GalleryImg], [ShowOnListing], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@ProductID, @GalleryName, @GalleryDesc, @GalleryImg, @ShowOnListing, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[ProductGalleries]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[ProductGalleries] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

            AlterStoredProcedure(
                "dbo.ProductGallery_Update",
                p => new
                {
                    Id = p.Long(),
                    ProductID = p.Long(),
                    GalleryName = p.String(maxLength: 500),
                    GalleryDesc = p.String(maxLength: 2000),
                    GalleryImg = p.String(maxLength: 2000),
                    ShowOnListing = p.Boolean(),
                    UpdatedDate = p.DateTime(),
                    IsActive = p.Boolean(),
                    IsDeleted = p.Boolean(),
                },
                body:
                    @"UPDATE [dbo].[ProductGalleries]
                      SET [ProductID] = @ProductID, [GalleryName] = @GalleryName, [GalleryDesc] = @GalleryDesc, [GalleryImg] = @GalleryImg, [ShowOnListing] = @ShowOnListing, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[ProductGalleries] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );

        }

        public override void Down()
        {
            DropStoredProcedure("dbo.CalulatorCategory_Delete");
            DropStoredProcedure("dbo.CalulatorCategory_Update");
            DropStoredProcedure("dbo.CalulatorCategory_Insert");
            DropForeignKey("dbo.Orders", "PaymentMode_Id", "dbo.PaymentModes");
            DropForeignKey("dbo.UserRoleRels", "UserType_Id", "dbo.UserTypes");
            DropForeignKey("dbo.Customers", "UserTypes_Id", "dbo.UserTypes");
            DropForeignKey("dbo.UserRoleRels", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.States", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Cities", "State_Id", "dbo.States");
            DropForeignKey("dbo.AddressBooks", "Cities_Id", "dbo.Cities");
            DropForeignKey("dbo.Products", "Brand_Id", "dbo.Brands");
            DropForeignKey("dbo.CalulatorCategoryProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.CalulatorCategoryProducts", "CalulatorCategory_Id", "dbo.CalulatorCategories");
            DropForeignKey("dbo.CategoryCalulatorCategories", "CalulatorCategory_Id", "dbo.CalulatorCategories");
            DropForeignKey("dbo.CategoryCalulatorCategories", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CalulatorCategoryProducts", new[] { "Product_Id" });
            DropIndex("dbo.CalulatorCategoryProducts", new[] { "CalulatorCategory_Id" });
            DropIndex("dbo.CategoryCalulatorCategories", new[] { "CalulatorCategory_Id" });
            DropIndex("dbo.CategoryCalulatorCategories", new[] { "Category_Id" });
            DropIndex("dbo.UserRoleRels", new[] { "UserType_Id" });
            DropIndex("dbo.UserRoleRels", new[] { "Role_Id" });
            DropIndex("dbo.States", new[] { "Country_Id" });
            DropIndex("dbo.Cities", new[] { "State_Id" });
            DropIndex("dbo.AddressBooks", new[] { "Cities_Id" });
            DropIndex("dbo.Customers", new[] { "UserTypes_Id" });
            DropIndex("dbo.Orders", new[] { "PaymentMode_Id" });
            DropIndex("dbo.Products", new[] { "Brand_Id" });
            DropPrimaryKey("dbo.PaymentModes");
            DropPrimaryKey("dbo.UserTypes");
            DropPrimaryKey("dbo.Roles");
            DropPrimaryKey("dbo.UserRoleRels");
            DropPrimaryKey("dbo.Countries");
            DropPrimaryKey("dbo.States");
            DropPrimaryKey("dbo.Cities");
            DropPrimaryKey("dbo.Brands");
            AlterColumn("dbo.ProductGalleries", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PaymentModes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.UserTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Roles", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.UserRoleRels", "UserType_Id", c => c.Int());
            AlterColumn("dbo.UserRoleRels", "Role_Id", c => c.Int());
            AlterColumn("dbo.UserRoleRels", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Countries", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.States", "Country_Id", c => c.Int());
            AlterColumn("dbo.States", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Cities", "State_Id", c => c.Int());
            AlterColumn("dbo.Cities", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.AddressBooks", "Cities_Id", c => c.Int());
            AlterColumn("dbo.Customers", "UserTypes_Id", c => c.Int());
            AlterColumn("dbo.Orders", "PaymentMode_Id", c => c.Int());
            AlterColumn("dbo.Products", "Brand_Id", c => c.Int());
            AlterColumn("dbo.Brands", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.UserTypes", "IsDeleted");
            DropColumn("dbo.UserTypes", "IsActive");
            DropColumn("dbo.ShoppingCartDetails", "IsDeleted");
            DropColumn("dbo.ShoppingCartDetails", "IsActive");
            DropColumn("dbo.ShoppingCarts", "IsDeleted");
            DropColumn("dbo.ShoppingCarts", "IsActive");
            DropColumn("dbo.Customers", "IsDeleted");
            DropColumn("dbo.Orders", "IsDeleted");
            DropColumn("dbo.Orders", "IsActive");
            DropColumn("dbo.Payments", "IsDeleted");
            DropColumn("dbo.Payments", "IsActive");
            DropColumn("dbo.PaymentDetails", "IsDeleted");
            DropColumn("dbo.PaymentDetails", "IsActive");
            DropColumn("dbo.OrderDetails", "IsDeleted");
            DropColumn("dbo.OrderDetails", "IsActive");
            DropTable("dbo.CalulatorCategoryProducts");
            DropTable("dbo.CategoryCalulatorCategories");
            DropTable("dbo.CalulatorCategories");
            AddPrimaryKey("dbo.PaymentModes", "Id");
            AddPrimaryKey("dbo.UserTypes", "Id");
            AddPrimaryKey("dbo.Roles", "Id");
            AddPrimaryKey("dbo.UserRoleRels", "Id");
            AddPrimaryKey("dbo.Countries", "Id");
            AddPrimaryKey("dbo.States", "Id");
            AddPrimaryKey("dbo.Cities", "Id");
            AddPrimaryKey("dbo.Brands", "Id");
            CreateIndex("dbo.UserRoleRels", "UserType_Id");
            CreateIndex("dbo.UserRoleRels", "Role_Id");
            CreateIndex("dbo.States", "Country_Id");
            CreateIndex("dbo.Cities", "State_Id");
            CreateIndex("dbo.AddressBooks", "Cities_Id");
            CreateIndex("dbo.Customers", "UserTypes_Id");
            CreateIndex("dbo.Orders", "PaymentMode_Id");
            CreateIndex("dbo.Products", "Brand_Id");
            AddForeignKey("dbo.Orders", "PaymentMode_Id", "dbo.PaymentModes", "Id");
            AddForeignKey("dbo.UserRoleRels", "UserType_Id", "dbo.UserTypes", "Id");
            AddForeignKey("dbo.Customers", "UserTypes_Id", "dbo.UserTypes", "Id");
            AddForeignKey("dbo.UserRoleRels", "Role_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.States", "Country_Id", "dbo.Countries", "Id");
            AddForeignKey("dbo.Cities", "State_Id", "dbo.States", "Id");
            AddForeignKey("dbo.AddressBooks", "Cities_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Products", "Brand_Id", "dbo.Brands", "Id");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
