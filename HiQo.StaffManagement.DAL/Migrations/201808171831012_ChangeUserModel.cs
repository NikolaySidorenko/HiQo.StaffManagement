namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "UserId");
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "Id");
            AddPrimaryKey("dbo.Users", "UserId");
        }
    }
}
