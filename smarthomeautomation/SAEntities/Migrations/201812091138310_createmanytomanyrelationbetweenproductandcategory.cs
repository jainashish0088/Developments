namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class createmanytomanyrelationbetweenproductandcategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryProducts",
                c => new
                {
                    //Id = c.Int(nullable: false, identity: true),
                    Category_Id = c.Long(nullable: false),
                    Product_Id = c.Long(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    UpdatedDate = c.DateTime()
                })
                .PrimaryKey(t => new { t.Category_Id, t.Product_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Product_Id);
        }

        public override void Down()
        {
            CreateTable(
                "dbo.ProductCategoryRelProducts",
                c => new
                {
                    ProductCategoryRel_Id = c.Long(nullable: false),
                    Product_Id = c.Long(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    UpdatedDate = c.DateTime()
                })
                .PrimaryKey(t => new { t.ProductCategoryRel_Id, t.Product_Id });

            CreateTable(
                "dbo.CategoryProductCategoryRels",
                c => new
                {
                    Category_Id = c.Long(nullable: false),
                    ProductCategoryRel_Id = c.Long(nullable: false),
                })
                .PrimaryKey(t => new { t.Category_Id, t.ProductCategoryRel_Id });

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

            DropForeignKey("dbo.CategoryProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.CategoryProducts", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CategoryProducts", new[] { "Product_Id" });
            DropIndex("dbo.CategoryProducts", new[] { "Category_Id" });
            DropTable("dbo.CategoryProducts");
            CreateIndex("dbo.ProductCategoryRelProducts", "Product_Id");
            CreateIndex("dbo.ProductCategoryRelProducts", "ProductCategoryRel_Id");
            CreateIndex("dbo.CategoryProductCategoryRels", "ProductCategoryRel_Id");
            CreateIndex("dbo.CategoryProductCategoryRels", "Category_Id");
            AddForeignKey("dbo.ProductCategoryRelProducts", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductCategoryRelProducts", "ProductCategoryRel_Id", "dbo.ProductCategoryRels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CategoryProductCategoryRels", "ProductCategoryRel_Id", "dbo.ProductCategoryRels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CategoryProductCategoryRels", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
