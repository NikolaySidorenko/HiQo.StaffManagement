// <auto-generated />
namespace HiQo.StaffManagement.DAL.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class AddSaltToUser : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddSaltToUser));
        
        string IMigrationMetadata.Id
        {
            get { return "201808201219006_AddSaltToUser"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
