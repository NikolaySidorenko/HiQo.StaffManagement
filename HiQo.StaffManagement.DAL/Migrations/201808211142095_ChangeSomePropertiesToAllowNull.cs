namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSomePropertiesToAllowNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Users", "DepartmentId", c => c.Int(nullable:true));
            AlterColumn("dbo.Users", "CategoryId", c => c.Int(nullable: true));
            AlterColumn("dbo.Users", "PositionId", c => c.Int(nullable: true));
            AlterColumn("dbo.Users", "PositionLevelId", c => c.Int(nullable: true));
            AlterColumn("dbo.Users", "RoleId", c => c.Int(nullable: true));

        }

        public override void Down()
        {
            AlterColumn("dbo.Users", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
