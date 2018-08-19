namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Users", "PasswordHash", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PasswordHash");
            DropColumn("dbo.Users", "Email");
        }
    }
}
