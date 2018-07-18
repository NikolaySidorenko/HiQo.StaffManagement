namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Positions", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.PositionLevels", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.PositionLevels", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Positions", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
