namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryAddShowInCalculatorProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "IsShowOnCalculator", c => c.Boolean(nullable: false));
            CreateStoredProcedure(
                "dbo.Brand_Insert",
                p => new
                    {
                        Name = p.String(maxLength: 200),
                        Desc = p.String(maxLength: 2000),
                        LargeImg = p.String(maxLength: 200),
                        SmallImg = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[Brands]([Name], [Desc], [LargeImg], [SmallImg], [IsActive], [IsDeleted], [UpdatedDate])
                      VALUES (@Name, @Desc, @LargeImg, @SmallImg, @IsActive, @IsDeleted, @UpdatedDate)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Brands]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Brands] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Brand_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(maxLength: 200),
                        Desc = p.String(maxLength: 2000),
                        LargeImg = p.String(maxLength: 200),
                        SmallImg = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[Brands]
                      SET [Name] = @Name, [Desc] = @Desc, [LargeImg] = @LargeImg, [SmallImg] = @SmallImg, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Brands] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Brand_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Brands]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Product_Insert",
                p => new
                    {
                        ProductName = p.String(maxLength: 1000),
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
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        ISDiscOnPercOrValue = p.Short(),
                        Brand_Id = p.Int(),
                        Supplier_Id = p.Long(),
                    },
                body:
                    @"INSERT [dbo].[Products]([ProductName], [ProductCode], [ProductShortDesc], [ProductDesc], [Quantity], [SellingPrice], [MRP], [Discount], [Tax], [AllowReturn], [ReturnDuration], [IsActive], [IsDeleted], [UpdatedDate], [ISDiscOnPercOrValue], [Brand_Id], [Supplier_Id])
                      VALUES (@ProductName, @ProductCode, @ProductShortDesc, @ProductDesc, @Quantity, @SellingPrice, @MRP, @Discount, @Tax, @AllowReturn, @ReturnDuration, @IsActive, @IsDeleted, @UpdatedDate, @ISDiscOnPercOrValue, @Brand_Id, @Supplier_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Products]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Products] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Product_Update",
                p => new
                    {
                        Id = p.Long(),
                        ProductName = p.String(maxLength: 1000),
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
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        ISDiscOnPercOrValue = p.Short(),
                        Brand_Id = p.Int(),
                        Supplier_Id = p.Long(),
                    },
                body:
                    @"UPDATE [dbo].[Products]
                      SET [ProductName] = @ProductName, [ProductCode] = @ProductCode, [ProductShortDesc] = @ProductShortDesc, [ProductDesc] = @ProductDesc, [Quantity] = @Quantity, [SellingPrice] = @SellingPrice, [MRP] = @MRP, [Discount] = @Discount, [Tax] = @Tax, [AllowReturn] = @AllowReturn, [ReturnDuration] = @ReturnDuration, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate, [ISDiscOnPercOrValue] = @ISDiscOnPercOrValue, [Brand_Id] = @Brand_Id, [Supplier_Id] = @Supplier_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Products] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Product_Delete",
                p => new
                    {
                        Id = p.Long(),
                        Brand_Id = p.Int(),
                        Supplier_Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[Products]
                      WHERE ((([Id] = @Id) AND (([Brand_Id] = @Brand_Id) OR ([Brand_Id] IS NULL AND @Brand_Id IS NULL))) AND (([Supplier_Id] = @Supplier_Id) OR ([Supplier_Id] IS NULL AND @Supplier_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        SequenceNumber = p.Long(),
                        IsShowOnCalculator = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[Categories]([CategoryId], [Name], [ShortDesc], [Desc], [MetaTitle], [MetaDesc], [MetaKeywords], [SmallImg], [LargeImg], [IsActive], [IsDeleted], [SequenceNumber], [IsShowOnCalculator], [UpdatedDate])
                      VALUES (@CategoryId, @Name, @ShortDesc, @Desc, @MetaTitle, @MetaDesc, @MetaKeywords, @SmallImg, @LargeImg, @IsActive, @IsDeleted, @SequenceNumber, @IsShowOnCalculator, @UpdatedDate)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Categories]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Categories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        SequenceNumber = p.Long(),
                        IsShowOnCalculator = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[Categories]
                      SET [CategoryId] = @CategoryId, [Name] = @Name, [ShortDesc] = @ShortDesc, [Desc] = @Desc, [MetaTitle] = @MetaTitle, [MetaDesc] = @MetaDesc, [MetaKeywords] = @MetaKeywords, [SmallImg] = @SmallImg, [LargeImg] = @LargeImg, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [SequenceNumber] = @SequenceNumber, [IsShowOnCalculator] = @IsShowOnCalculator, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Categories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Category_Delete",
                p => new
                    {
                        Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[Categories]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
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
                    },
                body:
                    @"INSERT [dbo].[OrderDetails]([OrderId], [ProductName], [ProductCode], [SellingPrice], [MRP], [Discount], [Tax], [UpdatedDate])
                      VALUES (@OrderId, @ProductName, @ProductCode, @SellingPrice, @MRP, @Discount, @Tax, @UpdatedDate)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[OrderDetails]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[OrderDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                    },
                body:
                    @"UPDATE [dbo].[OrderDetails]
                      SET [OrderId] = @OrderId, [ProductName] = @ProductName, [ProductCode] = @ProductCode, [SellingPrice] = @SellingPrice, [MRP] = @MRP, [Discount] = @Discount, [Tax] = @Tax, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[OrderDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.OrderDetail_Delete",
                p => new
                    {
                        Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[OrderDetails]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentDetail_Insert",
                p => new
                    {
                        Amount = p.Decimal(precision: 18, scale: 2),
                        UpdatedDate = p.DateTime(),
                        OrderDetail_Id = p.Long(),
                        Payment_Id = p.Long(),
                    },
                body:
                    @"INSERT [dbo].[PaymentDetails]([Amount], [UpdatedDate], [OrderDetail_Id], [Payment_Id])
                      VALUES (@Amount, @UpdatedDate, @OrderDetail_Id, @Payment_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[PaymentDetails]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[PaymentDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentDetail_Update",
                p => new
                    {
                        Id = p.Long(),
                        Amount = p.Decimal(precision: 18, scale: 2),
                        UpdatedDate = p.DateTime(),
                        OrderDetail_Id = p.Long(),
                        Payment_Id = p.Long(),
                    },
                body:
                    @"UPDATE [dbo].[PaymentDetails]
                      SET [Amount] = @Amount, [UpdatedDate] = @UpdatedDate, [OrderDetail_Id] = @OrderDetail_Id, [Payment_Id] = @Payment_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[PaymentDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentDetail_Delete",
                p => new
                    {
                        Id = p.Long(),
                        OrderDetail_Id = p.Long(),
                        Payment_Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[PaymentDetails]
                      WHERE ((([Id] = @Id) AND (([OrderDetail_Id] = @OrderDetail_Id) OR ([OrderDetail_Id] IS NULL AND @OrderDetail_Id IS NULL))) AND (([Payment_Id] = @Payment_Id) OR ([Payment_Id] IS NULL AND @Payment_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Payment_Insert",
                p => new
                    {
                        Amount = p.Decimal(precision: 18, scale: 2),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[Payments]([Amount], [UpdatedDate])
                      VALUES (@Amount, @UpdatedDate)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Payments]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Payments] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Payment_Update",
                p => new
                    {
                        Id = p.Long(),
                        Amount = p.Decimal(precision: 18, scale: 2),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[Payments]
                      SET [Amount] = @Amount, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Payments] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Payment_Delete",
                p => new
                    {
                        Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[Payments]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Order_Insert",
                p => new
                    {
                        TotalPrice = p.Decimal(precision: 18, scale: 2),
                        TotalDiscount = p.Decimal(precision: 18, scale: 2),
                        TotalTax = p.Decimal(precision: 18, scale: 2),
                        OrderNumber = p.String(),
                        UpdatedDate = p.DateTime(),
                        Customer_Id = p.Long(),
                        PaymentMode_Id = p.Int(),
                        Payment_Id = p.Long(),
                    },
                body:
                    @"INSERT [dbo].[Orders]([TotalPrice], [TotalDiscount], [TotalTax], [OrderNumber], [UpdatedDate], [Customer_Id], [PaymentMode_Id], [Payment_Id])
                      VALUES (@TotalPrice, @TotalDiscount, @TotalTax, @OrderNumber, @UpdatedDate, @Customer_Id, @PaymentMode_Id, @Payment_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Orders]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Orders] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Order_Update",
                p => new
                    {
                        Id = p.Long(),
                        TotalPrice = p.Decimal(precision: 18, scale: 2),
                        TotalDiscount = p.Decimal(precision: 18, scale: 2),
                        TotalTax = p.Decimal(precision: 18, scale: 2),
                        OrderNumber = p.String(),
                        UpdatedDate = p.DateTime(),
                        Customer_Id = p.Long(),
                        PaymentMode_Id = p.Int(),
                        Payment_Id = p.Long(),
                    },
                body:
                    @"UPDATE [dbo].[Orders]
                      SET [TotalPrice] = @TotalPrice, [TotalDiscount] = @TotalDiscount, [TotalTax] = @TotalTax, [OrderNumber] = @OrderNumber, [UpdatedDate] = @UpdatedDate, [Customer_Id] = @Customer_Id, [PaymentMode_Id] = @PaymentMode_Id, [Payment_Id] = @Payment_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Orders] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Order_Delete",
                p => new
                    {
                        Id = p.Long(),
                        Customer_Id = p.Long(),
                        PaymentMode_Id = p.Int(),
                        Payment_Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[Orders]
                      WHERE (((([Id] = @Id) AND (([Customer_Id] = @Customer_Id) OR ([Customer_Id] IS NULL AND @Customer_Id IS NULL))) AND (([PaymentMode_Id] = @PaymentMode_Id) OR ([PaymentMode_Id] IS NULL AND @PaymentMode_Id IS NULL))) AND (([Payment_Id] = @Payment_Id) OR ([Payment_Id] IS NULL AND @Payment_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Customer_Insert",
                p => new
                    {
                        FirstName = p.String(maxLength: 200),
                        MiddleName = p.String(maxLength: 200),
                        LastName = p.String(maxLength: 200),
                        DateofBirth = p.DateTime(),
                        EmailID = p.String(maxLength: 500),
                        MobileNo = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsMobileVerified = p.Boolean(),
                        IsEmailVerified = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        Suppliers_Id = p.Long(),
                        UserTypes_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Customers]([FirstName], [MiddleName], [LastName], [DateofBirth], [EmailID], [MobileNo], [IsActive], [IsMobileVerified], [IsEmailVerified], [UpdatedDate], [Suppliers_Id], [UserTypes_Id])
                      VALUES (@FirstName, @MiddleName, @LastName, @DateofBirth, @EmailID, @MobileNo, @IsActive, @IsMobileVerified, @IsEmailVerified, @UpdatedDate, @Suppliers_Id, @UserTypes_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Customers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Customers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                        IsActive = p.Boolean(),
                        IsMobileVerified = p.Boolean(),
                        IsEmailVerified = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        Suppliers_Id = p.Long(),
                        UserTypes_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Customers]
                      SET [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, [DateofBirth] = @DateofBirth, [EmailID] = @EmailID, [MobileNo] = @MobileNo, [IsActive] = @IsActive, [IsMobileVerified] = @IsMobileVerified, [IsEmailVerified] = @IsEmailVerified, [UpdatedDate] = @UpdatedDate, [Suppliers_Id] = @Suppliers_Id, [UserTypes_Id] = @UserTypes_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Customers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Customer_Delete",
                p => new
                    {
                        Id = p.Long(),
                        Suppliers_Id = p.Long(),
                        UserTypes_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Customers]
                      WHERE ((([Id] = @Id) AND (([Suppliers_Id] = @Suppliers_Id) OR ([Suppliers_Id] IS NULL AND @Suppliers_Id IS NULL))) AND (([UserTypes_Id] = @UserTypes_Id) OR ([UserTypes_Id] IS NULL AND @UserTypes_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.AddressBook_Insert",
                p => new
                    {
                        Address1 = p.String(maxLength: 500),
                        Address2 = p.String(maxLength: 500),
                        Address3 = p.String(maxLength: 500),
                        PostCode = p.String(maxLength: 20),
                        UpdatedDate = p.DateTime(),
                        Cities_Id = p.Int(),
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
            
            CreateStoredProcedure(
                "dbo.AddressBook_Update",
                p => new
                    {
                        Id = p.Long(),
                        Address1 = p.String(maxLength: 500),
                        Address2 = p.String(maxLength: 500),
                        Address3 = p.String(maxLength: 500),
                        PostCode = p.String(maxLength: 20),
                        UpdatedDate = p.DateTime(),
                        Cities_Id = p.Int(),
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
            
            CreateStoredProcedure(
                "dbo.AddressBook_Delete",
                p => new
                    {
                        Id = p.Long(),
                        Cities_Id = p.Int(),
                        Customer_Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[AddressBooks]
                      WHERE ((([Id] = @Id) AND (([Cities_Id] = @Cities_Id) OR ([Cities_Id] IS NULL AND @Cities_Id IS NULL))) AND (([Customer_Id] = @Customer_Id) OR ([Customer_Id] IS NULL AND @Customer_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.City_Insert",
                p => new
                    {
                        Name = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        State_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Cities]([Name], [IsActive], [IsDeleted], [UpdatedDate], [State_Id])
                      VALUES (@Name, @IsActive, @IsDeleted, @UpdatedDate, @State_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Cities]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Cities] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.City_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        State_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Cities]
                      SET [Name] = @Name, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate, [State_Id] = @State_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Cities] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.City_Delete",
                p => new
                    {
                        Id = p.Int(),
                        State_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Cities]
                      WHERE (([Id] = @Id) AND (([State_Id] = @State_Id) OR ([State_Id] IS NULL AND @State_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.State_Insert",
                p => new
                    {
                        Name = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        Country_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[States]([Name], [IsActive], [IsDeleted], [UpdatedDate], [Country_Id])
                      VALUES (@Name, @IsActive, @IsDeleted, @UpdatedDate, @Country_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[States]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[States] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.State_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        Country_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[States]
                      SET [Name] = @Name, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate, [Country_Id] = @Country_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[States] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.State_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Country_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[States]
                      WHERE (([Id] = @Id) AND (([Country_Id] = @Country_Id) OR ([Country_Id] IS NULL AND @Country_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Country_Insert",
                p => new
                    {
                        Name = p.String(maxLength: 200),
                        Code = p.String(maxLength: 10),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[Countries]([Name], [Code], [IsActive], [IsDeleted], [UpdatedDate])
                      VALUES (@Name, @Code, @IsActive, @IsDeleted, @UpdatedDate)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Countries]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Countries] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Country_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(maxLength: 200),
                        Code = p.String(maxLength: 10),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[Countries]
                      SET [Name] = @Name, [Code] = @Code, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Countries] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Country_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Countries]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ShoppingCart_Insert",
                p => new
                    {
                        UpdatedDate = p.DateTime(),
                        Customer_Id = p.Long(),
                    },
                body:
                    @"INSERT [dbo].[ShoppingCarts]([UpdatedDate], [Customer_Id])
                      VALUES (@UpdatedDate, @Customer_Id)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[ShoppingCarts]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[ShoppingCarts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.ShoppingCart_Update",
                p => new
                    {
                        Id = p.Long(),
                        UpdatedDate = p.DateTime(),
                        Customer_Id = p.Long(),
                    },
                body:
                    @"UPDATE [dbo].[ShoppingCarts]
                      SET [UpdatedDate] = @UpdatedDate, [Customer_Id] = @Customer_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[ShoppingCarts] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.ShoppingCart_Delete",
                p => new
                    {
                        Id = p.Long(),
                        Customer_Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[ShoppingCarts]
                      WHERE (([Id] = @Id) AND (([Customer_Id] = @Customer_Id) OR ([Customer_Id] IS NULL AND @Customer_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
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
                    },
                body:
                    @"INSERT [dbo].[ShoppingCartDetails]([ShoppingCartId], [ProductName], [ProductCode], [SellingPrice], [MRP], [Discount], [Tax], [IsCancelled], [UpdatedDate])
                      VALUES (@ShoppingCartId, @ProductName, @ProductCode, @SellingPrice, @MRP, @Discount, @Tax, @IsCancelled, @UpdatedDate)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[ShoppingCartDetails]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[ShoppingCartDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
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
                    },
                body:
                    @"UPDATE [dbo].[ShoppingCartDetails]
                      SET [ShoppingCartId] = @ShoppingCartId, [ProductName] = @ProductName, [ProductCode] = @ProductCode, [SellingPrice] = @SellingPrice, [MRP] = @MRP, [Discount] = @Discount, [Tax] = @Tax, [IsCancelled] = @IsCancelled, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[ShoppingCartDetails] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.ShoppingCartDetail_Delete",
                p => new
                    {
                        Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[ShoppingCartDetails]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.Supplier_Insert",
                p => new
                    {
                        CompanyName = p.String(),
                        EmailId = p.String(maxLength: 500),
                        ContactNumber = p.String(maxLength: 200),
                        CompanyFaxNumber = p.String(),
                        GSTNumber = p.String(),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[Suppliers]([CompanyName], [EmailId], [ContactNumber], [CompanyFaxNumber], [GSTNumber], [IsActive], [IsDeleted], [UpdatedDate])
                      VALUES (@CompanyName, @EmailId, @ContactNumber, @CompanyFaxNumber, @GSTNumber, @IsActive, @IsDeleted, @UpdatedDate)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[Suppliers]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Suppliers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Supplier_Update",
                p => new
                    {
                        Id = p.Long(),
                        CompanyName = p.String(),
                        EmailId = p.String(maxLength: 500),
                        ContactNumber = p.String(maxLength: 200),
                        CompanyFaxNumber = p.String(),
                        GSTNumber = p.String(),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[Suppliers]
                      SET [CompanyName] = @CompanyName, [EmailId] = @EmailId, [ContactNumber] = @ContactNumber, [CompanyFaxNumber] = @CompanyFaxNumber, [GSTNumber] = @GSTNumber, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Suppliers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Supplier_Delete",
                p => new
                    {
                        Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[Suppliers]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.UserRoleRel_Insert",
                p => new
                    {
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        Customer_Id = p.Long(),
                        Role_Id = p.Int(),
                        UserType_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[UserRoleRels]([IsActive], [IsDeleted], [UpdatedDate], [Customer_Id], [Role_Id], [UserType_Id])
                      VALUES (@IsActive, @IsDeleted, @UpdatedDate, @Customer_Id, @Role_Id, @UserType_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[UserRoleRels]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[UserRoleRels] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UserRoleRel_Update",
                p => new
                    {
                        Id = p.Int(),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        Customer_Id = p.Long(),
                        Role_Id = p.Int(),
                        UserType_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[UserRoleRels]
                      SET [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate, [Customer_Id] = @Customer_Id, [Role_Id] = @Role_Id, [UserType_Id] = @UserType_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[UserRoleRels] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UserRoleRel_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Customer_Id = p.Long(),
                        Role_Id = p.Int(),
                        UserType_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[UserRoleRels]
                      WHERE (((([Id] = @Id) AND (([Customer_Id] = @Customer_Id) OR ([Customer_Id] IS NULL AND @Customer_Id IS NULL))) AND (([Role_Id] = @Role_Id) OR ([Role_Id] IS NULL AND @Role_Id IS NULL))) AND (([UserType_Id] = @UserType_Id) OR ([UserType_Id] IS NULL AND @UserType_Id IS NULL)))"
            );
            
            CreateStoredProcedure(
                "dbo.Role_Insert",
                p => new
                    {
                        Name = p.String(maxLength: 30),
                        Desc = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[Roles]([Name], [Desc], [IsActive], [IsDeleted], [UpdatedDate])
                      VALUES (@Name, @Desc, @IsActive, @IsDeleted, @UpdatedDate)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Roles]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[Roles] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Role_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(maxLength: 30),
                        Desc = p.String(maxLength: 200),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[Roles]
                      SET [Name] = @Name, [Desc] = @Desc, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Roles] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Role_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Roles]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.UserType_Insert",
                p => new
                    {
                        Name = p.String(maxLength: 50),
                        Desc = p.String(maxLength: 200),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[UserTypes]([Name], [Desc], [UpdatedDate])
                      VALUES (@Name, @Desc, @UpdatedDate)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[UserTypes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[UserTypes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UserType_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(maxLength: 50),
                        Desc = p.String(maxLength: 200),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[UserTypes]
                      SET [Name] = @Name, [Desc] = @Desc, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[UserTypes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UserType_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[UserTypes]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentMode_Insert",
                p => new
                    {
                        PayName = p.String(maxLength: 200),
                        PayDesc = p.String(maxLength: 1000),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[PaymentModes]([PayName], [PayDesc], [IsActive], [IsDeleted], [UpdatedDate])
                      VALUES (@PayName, @PayDesc, @IsActive, @IsDeleted, @UpdatedDate)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[PaymentModes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[PaymentModes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentMode_Update",
                p => new
                    {
                        Id = p.Int(),
                        PayName = p.String(maxLength: 200),
                        PayDesc = p.String(maxLength: 1000),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[PaymentModes]
                      SET [PayName] = @PayName, [PayDesc] = @PayDesc, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[PaymentModes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.PaymentMode_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[PaymentModes]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ProductGallery_Insert",
                p => new
                    {
                        ProductID = p.Long(),
                        GalleryName = p.String(maxLength: 500),
                        GalleryDesc = p.String(maxLength: 2000),
                        GalleryImg = p.String(maxLength: 2000),
                        ShowOnListing = p.Boolean(),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        CreatedDate = p.DateTime(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[ProductGalleries]([ProductID], [GalleryName], [GalleryDesc], [GalleryImg], [ShowOnListing], [IsActive], [IsDeleted], [CreatedDate], [UpdatedDate])
                      VALUES (@ProductID, @GalleryName, @GalleryDesc, @GalleryImg, @ShowOnListing, @IsActive, @IsDeleted, @CreatedDate, @UpdatedDate)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[ProductGalleries]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[ProductGalleries] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.ProductGallery_Update",
                p => new
                    {
                        Id = p.Long(),
                        ProductID = p.Long(),
                        GalleryName = p.String(maxLength: 500),
                        GalleryDesc = p.String(maxLength: 2000),
                        GalleryImg = p.String(maxLength: 2000),
                        ShowOnListing = p.Boolean(),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        CreatedDate = p.DateTime(),
                        UpdatedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[ProductGalleries]
                      SET [ProductID] = @ProductID, [GalleryName] = @GalleryName, [GalleryDesc] = @GalleryDesc, [GalleryImg] = @GalleryImg, [ShowOnListing] = @ShowOnListing, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [CreatedDate] = @CreatedDate, [UpdatedDate] = @UpdatedDate
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.ProductGallery_Delete",
                p => new
                    {
                        Id = p.Long(),
                    },
                body:
                    @"DELETE [dbo].[ProductGalleries]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.ProductGallery_Delete");
            DropStoredProcedure("dbo.ProductGallery_Update");
            DropStoredProcedure("dbo.ProductGallery_Insert");
            DropStoredProcedure("dbo.PaymentMode_Delete");
            DropStoredProcedure("dbo.PaymentMode_Update");
            DropStoredProcedure("dbo.PaymentMode_Insert");
            DropStoredProcedure("dbo.UserType_Delete");
            DropStoredProcedure("dbo.UserType_Update");
            DropStoredProcedure("dbo.UserType_Insert");
            DropStoredProcedure("dbo.Role_Delete");
            DropStoredProcedure("dbo.Role_Update");
            DropStoredProcedure("dbo.Role_Insert");
            DropStoredProcedure("dbo.UserRoleRel_Delete");
            DropStoredProcedure("dbo.UserRoleRel_Update");
            DropStoredProcedure("dbo.UserRoleRel_Insert");
            DropStoredProcedure("dbo.Supplier_Delete");
            DropStoredProcedure("dbo.Supplier_Update");
            DropStoredProcedure("dbo.Supplier_Insert");
            DropStoredProcedure("dbo.ShoppingCartDetail_Delete");
            DropStoredProcedure("dbo.ShoppingCartDetail_Update");
            DropStoredProcedure("dbo.ShoppingCartDetail_Insert");
            DropStoredProcedure("dbo.ShoppingCart_Delete");
            DropStoredProcedure("dbo.ShoppingCart_Update");
            DropStoredProcedure("dbo.ShoppingCart_Insert");
            DropStoredProcedure("dbo.Country_Delete");
            DropStoredProcedure("dbo.Country_Update");
            DropStoredProcedure("dbo.Country_Insert");
            DropStoredProcedure("dbo.State_Delete");
            DropStoredProcedure("dbo.State_Update");
            DropStoredProcedure("dbo.State_Insert");
            DropStoredProcedure("dbo.City_Delete");
            DropStoredProcedure("dbo.City_Update");
            DropStoredProcedure("dbo.City_Insert");
            DropStoredProcedure("dbo.AddressBook_Delete");
            DropStoredProcedure("dbo.AddressBook_Update");
            DropStoredProcedure("dbo.AddressBook_Insert");
            DropStoredProcedure("dbo.Customer_Delete");
            DropStoredProcedure("dbo.Customer_Update");
            DropStoredProcedure("dbo.Customer_Insert");
            DropStoredProcedure("dbo.Order_Delete");
            DropStoredProcedure("dbo.Order_Update");
            DropStoredProcedure("dbo.Order_Insert");
            DropStoredProcedure("dbo.Payment_Delete");
            DropStoredProcedure("dbo.Payment_Update");
            DropStoredProcedure("dbo.Payment_Insert");
            DropStoredProcedure("dbo.PaymentDetail_Delete");
            DropStoredProcedure("dbo.PaymentDetail_Update");
            DropStoredProcedure("dbo.PaymentDetail_Insert");
            DropStoredProcedure("dbo.OrderDetail_Delete");
            DropStoredProcedure("dbo.OrderDetail_Update");
            DropStoredProcedure("dbo.OrderDetail_Insert");
            DropStoredProcedure("dbo.Category_Delete");
            DropStoredProcedure("dbo.Category_Update");
            DropStoredProcedure("dbo.Category_Insert");
            DropStoredProcedure("dbo.Product_Delete");
            DropStoredProcedure("dbo.Product_Update");
            DropStoredProcedure("dbo.Product_Insert");
            DropStoredProcedure("dbo.Brand_Delete");
            DropStoredProcedure("dbo.Brand_Update");
            DropStoredProcedure("dbo.Brand_Insert");
            DropColumn("dbo.Categories", "IsShowOnCalculator");
        }
    }
}
