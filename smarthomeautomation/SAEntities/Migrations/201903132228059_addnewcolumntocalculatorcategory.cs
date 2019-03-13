namespace SAEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewcolumntocalculatorcategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalulatorCategories", "MustAddInList", c => c.Boolean(nullable: false));
            AlterStoredProcedure(
                "dbo.CalulatorCategory_Insert",
                p => new
                    {
                        Name = p.String(),
                        MustAddInList = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                    },
                body:
                    @"INSERT [dbo].[CalulatorCategories]([Name], [MustAddInList], [UpdatedDate], [IsActive], [IsDeleted])
                      VALUES (@Name, @MustAddInList, @UpdatedDate, @IsActive, @IsDeleted)
                      
                      DECLARE @Id bigint
                      SELECT @Id = [Id]
                      FROM [dbo].[CalulatorCategories]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id], t0.[CreatedDate]
                      FROM [dbo].[CalulatorCategories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            AlterStoredProcedure(
                "dbo.CalulatorCategory_Update",
                p => new
                    {
                        Id = p.Long(),
                        Name = p.String(),
                        MustAddInList = p.Boolean(),
                        UpdatedDate = p.DateTime(),
                        IsActive = p.Boolean(),
                        IsDeleted = p.Boolean(),
                    },
                body:
                    @"UPDATE [dbo].[CalulatorCategories]
                      SET [Name] = @Name, [MustAddInList] = @MustAddInList, [UpdatedDate] = @UpdatedDate, [IsActive] = @IsActive, [IsDeleted] = @IsDeleted
                      WHERE ([Id] = @Id)
                      
                      SELECT t0.[CreatedDate]
                      FROM [dbo].[CalulatorCategories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.CalulatorCategories", "MustAddInList");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
