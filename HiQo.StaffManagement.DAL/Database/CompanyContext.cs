using System.Data.Entity;
using HiQo.StaffManagement.DAL.Database.Entities;

namespace HiQo.StaffManagement.DAL.Database
{
    public class CompanyContext:DbContext
    {
        public CompanyContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=HiQo.StaffManagement;Integrated Security=True")
        {
           System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<CompanyContext, Migrations.Configuration>());
        } 

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Department> Departments { get; set; }

        public IDbSet<Role> Roles { get; set; }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Position> Positions { get; set; }

        public IDbSet<PositionLevel> PositionLevels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            SetupRoleConfig(modelBuilder);
            
            SetupUserConfig(modelBuilder);
            
            SetupPositionConfig(modelBuilder);
            
            SetupPositionLevelConfig(modelBuilder);
            
            SetupCategoryConfig(modelBuilder);
            
            SetupDepartmentConfig(modelBuilder);
        }

        private void SetupRoleConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasMany(r => r.Users).WithRequired(u => u.Role).HasForeignKey(u => u.RoleId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Role>().Property(r => r.Name).HasMaxLength(40).IsRequired();
            modelBuilder.Entity<Role>().HasKey(r => r.RoleId);
        }

        private void SetupUserConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.UserId);
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasMaxLength(40).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.LastName).HasMaxLength(40).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.UserName).HasMaxLength(40).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.DateOfBirth).IsRequired();
        }

        private void SetupPositionConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasMany(p=>p.Users).WithRequired(u=>u.Position).HasForeignKey(u=>u.PositionId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Position>().HasKey(p => p.PositionId);
            modelBuilder.Entity<Position>().Property(p => p.Name).HasMaxLength(40).IsRequired();
            
        }

        private void SetupPositionLevelConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PositionLevel>().HasMany(pl=>pl.Users).WithRequired(u=>u.PositionLevel).HasForeignKey(u=>u.PositionLevelId).WillCascadeOnDelete(false);
            modelBuilder.Entity<PositionLevel>().HasKey(pl => pl.PositionLevelId);
            modelBuilder.Entity<PositionLevel>().Property(pl => pl.Name).HasMaxLength(40).IsRequired();
        }

        private void SetupCategoryConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c=>c.Users).WithRequired(u=>u.Category).HasForeignKey(u=>u.CategoryId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Category>().HasMany(c => c.Positions).WithRequired(p =>p.Category).HasForeignKey(p=>p.CategoryId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(40).IsRequired();
        }

        private void SetupDepartmentConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasMany(d => d.Users).WithRequired(u => u.Department).HasForeignKey(u=>u.DepartmentId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Department>().HasMany(d=>d.Categories).WithRequired(c=>c.Department).HasForeignKey(c=>c.DepartmentId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Department>().HasKey(d => d.DepartmentId);
            modelBuilder.Entity<Department>().Property(d => d.Name).HasMaxLength(40).IsRequired();
        }

    }
}
