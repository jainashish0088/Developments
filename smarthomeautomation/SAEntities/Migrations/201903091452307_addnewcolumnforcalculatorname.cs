namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewcolumnforcalculatorname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "NameForCalculator", c => c.String(maxLength: 1000));
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
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        ISDiscOnPercOrValue = p.Short(),
                        Brand_Id = p.Int(),
                        Supplier_Id = p.Long(),
                    },
                body:
                    @"INSERT [dbo].[Products]([ProductName], [NameForCalculator], [ProductCode], [ProductShortDesc], [ProductDesc], [Quantity], [SellingPrice], [MRP], [Discount], [Tax], [AllowReturn], [ReturnDuration], [IsActive], [IsDeleted], [UpdatedDate], [ISDiscOnPercOrValue], [Brand_Id], [Supplier_Id])
                      VALUES (@ProductName, @NameForCalculator, @ProductCode, @ProductShortDesc, @ProductDesc, @Quantity, @SellingPrice, @MRP, @Discount, @Tax, @AllowReturn, @ReturnDuration, @IsActive, @IsDeleted, @UpdatedDate, @ISDiscOnPercOrValue, @Brand_Id, @Supplier_Id)
                      
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
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        ISDiscOnPercOrValue = p.Short(),
                        Brand_Id = p.Int(),
                        Supplier_Id = p.Long(),
                    },
                body:
                    @"UPDATE [dbo].[Products]
                      SET [ProductName] = @ProductName, [NameForCalculator] = @NameForCalculator, [ProductCode] = @ProductCode, [ProductShortDesc] = @ProductShortDesc, [ProductDesc] = @ProductDesc, [Quantity] = @Quantity, [SellingPrice] = @SellingPrice, [MRP] = @MRP, [Discount] = @Discount, [Tax] = @Tax, [AllowReturn] = @AllowReturn, [ReturnDuration] = @ReturnDuration, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted, [UpdatedDate] = @UpdatedDate, [ISDiscOnPercOrValue] = @ISDiscOnPercOrValue, [Brand_Id] = @Brand_Id, [Supplier_Id] = @Supplier_Id
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[Products] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "NameForCalculator");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
