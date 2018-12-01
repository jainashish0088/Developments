namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSupplierCustomer : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "EmailID" });
            DropIndex("dbo.Customers", new[] { "MobileNo" });
            AlterColumn("dbo.Customers", "EmailID", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Customers", "MobileNo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Suppliers", "EmailId", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Suppliers", "ContactNumber", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.Customers", "EmailID", unique: true);
            CreateIndex("dbo.Customers", "MobileNo", unique: true);
            CreateIndex("dbo.Suppliers", "EmailId", unique: true);
            CreateIndex("dbo.Suppliers", "ContactNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Suppliers", new[] { "ContactNumber" });
            DropIndex("dbo.Suppliers", new[] { "EmailId" });
            DropIndex("dbo.Customers", new[] { "MobileNo" });
            DropIndex("dbo.Customers", new[] { "EmailID" });
            AlterColumn("dbo.Suppliers", "ContactNumber", c => c.String());
            AlterColumn("dbo.Suppliers", "EmailId", c => c.String());
            AlterColumn("dbo.Customers", "MobileNo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Customers", "EmailID", c => c.String(maxLength: 500));
            CreateIndex("dbo.Customers", "MobileNo", unique: true);
            CreateIndex("dbo.Customers", "EmailID", unique: true);
        }
    }
}
