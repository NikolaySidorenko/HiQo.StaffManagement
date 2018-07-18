namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabaseCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Categories",
                    c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        UserName = c.String(nullable: false, maxLength: 30),
                        DateOfBirth = c.DateTime(nullable: false),
                        RoleId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        PositionLevelId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Positions", t => t.PositionId)
                .ForeignKey("dbo.PositionLevels", t => t.PositionLevelId)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.RoleId)
                .Index(t => t.PositionId)
                .Index(t => t.PositionLevelId)
                .Index(t => t.DepartmentId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PositionId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.PositionLevels",
                c => new
                    {
                        PositionLevelId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Level = c.Int(),
                    })
                .PrimaryKey(t => t.PositionLevelId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Positions", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "PositionLevelId", "dbo.PositionLevels");
            DropForeignKey("dbo.Users", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Categories", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Positions", new[] { "CategoryId" });
            DropIndex("dbo.Users", new[] { "CategoryId" });
            DropIndex("dbo.Users", new[] { "DepartmentId" });
            DropIndex("dbo.Users", new[] { "PositionLevelId" });
            DropIndex("dbo.Users", new[] { "PositionId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Categories", new[] { "DepartmentId" });
            DropTable("dbo.Roles");
            DropTable("dbo.PositionLevels");
            DropTable("dbo.Positions");
            DropTable("dbo.Users");
            DropTable("dbo.Departments");
            DropTable("dbo.Categories");
        }
    }
}
