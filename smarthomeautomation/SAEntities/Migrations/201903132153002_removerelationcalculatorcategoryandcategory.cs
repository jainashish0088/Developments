namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removerelationcalculatorcategoryandcategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CategoryCalulatorCategories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.CategoryCalulatorCategories", "CalulatorCategory_Id", "dbo.CalulatorCategories");
            DropIndex("dbo.CategoryCalulatorCategories", new[] { "Category_Id" });
            DropIndex("dbo.CategoryCalulatorCategories", new[] { "CalulatorCategory_Id" });
            DropTable("dbo.CategoryCalulatorCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CategoryCalulatorCategories",
                c => new
                    {
                        Category_Id = c.Long(nullable: false),
                        CalulatorCategory_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.CalulatorCategory_Id });
            
            CreateIndex("dbo.CategoryCalulatorCategories", "CalulatorCategory_Id");
            CreateIndex("dbo.CategoryCalulatorCategories", "Category_Id");
            AddForeignKey("dbo.CategoryCalulatorCategories", "CalulatorCategory_Id", "dbo.CalulatorCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CategoryCalulatorCategories", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
