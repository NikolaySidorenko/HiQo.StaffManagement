using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;

namespace HiQo.StaffManagement.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CompanyContext context)
        {
            //var roles = new List<Role>
            //{
            //    new Role {RoleId = 1, Name = "SuperAdmin"},
            //    new Role {RoleId = 2, Name = "Admin"},
            //    new Role {RoleId = 3, Name = "User"}
            //};

            //var departments = new List<Department>
            //{
            //    new Department {DepartmentId = 1, Name = "Software Development"},
            //    new Department {DepartmentId = 2, Name = "Quality Assurance"},
            //    new Department {DepartmentId = 3, Name = "Resource Management"},
            //    new Department {DepartmentId = 4, Name = "Business Analyst"}
            //};

            //var categories = new List<Category>
            //{
            //    new Category
            //    {
            //        CategoryId = 1,
            //        Name = ".NET Development",
            //        DepartmentId = departments.First(d => d.Name == "Software Development").DepartmentId
            //    },
            //    new Category
            //    {
            //        CategoryId = 2,
            //        Name = "Java Development",
            //        DepartmentId = departments.First(d => d.Name == "Software Development").DepartmentId
            //    },
            //    new Category
            //    {
            //        CategoryId = 3,
            //        Name = "Front-End Development",
            //        DepartmentId = departments.First(d => d.Name == "Software Development").DepartmentId
            //    },
            //    new Category
            //    {
            //        CategoryId = 4,
            //        Name = "Business Analysis",
            //        DepartmentId = departments.First(d => d.Name == "Business Analyst").DepartmentId
            //    },
            //    new Category
            //    {
            //        CategoryId = 5,
            //        Name = "Quality Assurance",
            //        DepartmentId = departments.First(d => d.Name == "Quality Assurance").DepartmentId
            //    },
            //    new Category
            //    {
            //        CategoryId = 6,
            //        Name = "Administration Staff",
            //        DepartmentId = departments.First(d => d.Name == "Resource Management").DepartmentId
            //    },
            //    new Category
            //    {
            //        CategoryId = 7,
            //        Name = "Management",
            //        DepartmentId = departments.First(d => d.Name == "Resource Management").DepartmentId
            //    }
            //};

            //var positions = new List<Position>
            //{
            //    new Position
            //    {
            //        PositionId = 1,
            //        Name = ".NET Developer",
            //        CategoryId = categories.First(c => c.Name == ".NET Development").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 2,
            //        Name = "Java Developer",
            //        CategoryId = categories.First(c => c.Name == "Java Development").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 3,
            //        Name = "Front-End Developer",
            //        CategoryId = categories.First(c => c.Name == "Front-End Development").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 4,
            //        Name = "CEO",
            //        CategoryId = categories.First(c => c.Name == "Management").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 5,
            //        Name = "CTO",
            //        CategoryId = categories.First(c => c.Name == "Management").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 6,
            //        Name = "English Teacher",
            //        CategoryId = categories.First(c => c.Name == "Administration Staff").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 7,
            //        Name = "HR",
            //        CategoryId = categories.First(c => c.Name == "Administration Staff").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 8,
            //        Name = "Accountant",
            //        CategoryId = categories.First(c => c.Name == "Administration Staff").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 9,
            //        Name = "Administrator",
            //        CategoryId = categories.First(c => c.Name == "Administration Staff").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 10,
            //        Name = "Resource Manager",
            //        CategoryId = categories.First(c => c.Name == "Administration Staff").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 11,
            //        Name = "Business Analyst",
            //        CategoryId = categories.First(c => c.Name == "Business Analysis").CategoryId
            //    },
            //    new Position
            //    {
            //        PositionId = 12,
            //        Name = "QA Engineer",
            //        CategoryId = categories.First(c => c.Name == "Quality Assurance").CategoryId
            //    }
            //};

            //var positionLevels = new List<PositionLevel>
            //{
            //    new PositionLevel {PositionLevelId = 1, Name = "Intern", Level = 0},
            //    new PositionLevel {PositionLevelId = 2, Name = "Junior", Level = 0},
            //    new PositionLevel {PositionLevelId = 3, Name = "Junior", Level = 1},
            //    new PositionLevel {PositionLevelId = 4, Name = "Junior", Level = 2},
            //    new PositionLevel {PositionLevelId = 5, Name = "Staff", Level = 0},
            //    new PositionLevel {PositionLevelId = 6, Name = "Staff", Level = 1},
            //    new PositionLevel {PositionLevelId = 7, Name = "Staff", Level = 2},
            //    new PositionLevel {PositionLevelId = 8, Name = "Senior", Level = 0},
            //    new PositionLevel {PositionLevelId = 9, Name = "Senior", Level = 1},
            //    new PositionLevel {PositionLevelId = 10, Name = "Senior", Level = 2}
            //};
            //var md5 = new MD5CryptoServiceProvider();
            //md5.ComputeHash(Encoding.ASCII.GetBytes("SuperAdmin1234" + "sdsad21312dsad"));

            //var users = new List<User>
            //{
               
            //    new User
            //    {
            //        Id = 10,
            //        FirstName = "Admin",
            //        LastName = "Admin",
            //        UserName = "SuperAdmin",
            //        Email = "SuperAdmin@Admin.com",
            //        PasswordHash = BitConverter.ToString(md5.Hash),
            //        Salt="sdsad21312dsad",
            //        DateOfBirth = new DateTime(1999, 07, 8),
            //        DepartmentId = 1,
            //        CategoryId =1,
            //        PositionId = 1,
            //        PositionLevelId = 1,
            //        RoleId = 1
            //    }
            //};

            //roles.ForEach(r => context.Roles.AddOrUpdate(r));
            //departments.ForEach(d => context.Departments.AddOrUpdate(d));
            //positions.ForEach(p => context.Positions.AddOrUpdate(p));
            //positionLevels.ForEach(p => context.PositionLevels.AddOrUpdate(p));
            //categories.ForEach(c => context.Categories.AddOrUpdate(c));
            //users.ForEach(u => context.Users.AddOrUpdate(u));
            //context.SaveChanges();
        }
    }
}