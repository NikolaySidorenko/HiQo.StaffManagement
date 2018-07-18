using System.Collections.Generic;
using HiQo.StaffManagement.DAL.Database.Models;

namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HiQo.StaffManagement.DAL.Database.CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HiQo.StaffManagement.DAL.Database.CompanyContext context)
        {
            string[] roles = new string[] {"SuperAdmin", "Admin", "User"};
            for (int i = 0; i < roles.Length; i++)
            {
                context.Roles.AddOrUpdate(new Role {RoleId = i + 1, Name = roles[i]});
            }

            string[] departments=new string[] { "Software Development", "Quality Assurance","Resource Management", "Business Analyst" };
            for (int i = 0; i < departments.Length; i++)
            {
                context.Departments.AddOrUpdate(new Department() {DepartmentId = i + 1, Name = departments[i]});
            }

            List<Category> categories=new List<Category>()
            {
                new Category() { CategoryId = 1,Name= ".NET Development" ,DepartmentId = 1},
                new Category() { CategoryId = 2,Name= "Java Development" ,DepartmentId = 1},
                new Category() { CategoryId = 3,Name= "Front-End Development" ,DepartmentId = 1},
                new Category() { CategoryId = 4,Name= "Business Analysis" ,DepartmentId = 4},
                new Category() { CategoryId = 5,Name= "Quality Assurance" ,DepartmentId = 2},
                new Category() { CategoryId = 6,Name= "Administration Staff" ,DepartmentId = 3},
                new Category() { CategoryId = 7,Name= "Management" ,DepartmentId = 3},
            };
            categories.ForEach(c=>context.Categories.AddOrUpdate(c));

            List<Position> positions = new List<Position>()
            {
                new Position() {PositionId = 1, Name = ".NET Developer", CategoryId = 1},
                new Position() {PositionId = 2, Name = "Java Developer", CategoryId = 2},
                new Position() {PositionId = 3, Name = "Front-End Developer", CategoryId = 3},
                new Position() {PositionId = 4, Name = "CEO", CategoryId = 7},
                new Position() {PositionId = 5, Name = "CTO", CategoryId = 7},
                new Position() {PositionId = 6, Name = "English Teacher", CategoryId = 6},
                new Position() {PositionId = 6, Name = "HR", CategoryId = 6},
                new Position() {PositionId = 6, Name = "Accountant", CategoryId = 6},
                new Position() {PositionId = 6, Name = "Administrator", CategoryId = 6},
                new Position() {PositionId = 6, Name = "Resource Manager", CategoryId = 6},
                new Position() {PositionId = 6, Name = "Business Analyst", CategoryId = 4},
                new Position() {PositionId = 6, Name = "QA Engineer", CategoryId = 5},
            };
            positions.ForEach(p=>context.Positions.AddOrUpdate(p));

            List<PositionLevel> positionLevels = new List<PositionLevel>()
            {
                new PositionLevel(){PositionLevelId = 1,Name = "Intern",Level = 0},
                new PositionLevel(){PositionLevelId = 2,Name = "Junior",Level = 0},
                new PositionLevel(){PositionLevelId = 3,Name = "Junior",Level = 1},
                new PositionLevel(){PositionLevelId = 4,Name = "Junior",Level = 2},
                new PositionLevel(){PositionLevelId = 5,Name = "Staff",Level = 0},
                new PositionLevel(){PositionLevelId = 6,Name = "Staff",Level = 1},
                new PositionLevel(){PositionLevelId = 7,Name = "Staff",Level = 2},
                new PositionLevel(){PositionLevelId = 8,Name = "Senior",Level = 0},
                new PositionLevel(){PositionLevelId = 9,Name = "Senior",Level = 1},
                new PositionLevel(){PositionLevelId = 10,Name = "Senior",Level = 2},
            };
            positionLevels.ForEach(p=>context.PositionLevels.AddOrUpdate(p));

            List<User> users=new List<User>()
            {
                new User(){UserId = 1,
                    FirstName = "Nikolay",
                    LastName = "Sidorenko",
                    UserName = "Kolya",
                    DateOfBirth = new DateTime(1999,05,20),
                    DepartmentId = 1,
                    CategoryId = 1,
                    PositionId = 1,
                    PositionLevelId = 1,
                    RoleId = 3
                },

                new User(){
                    UserId = 2,
                    FirstName = "Kirill",
                    LastName = "Dudkov",
                    UserName = "Kirill",
                    DateOfBirth = new DateTime(1997,10,21),
                    DepartmentId = 1,
                    CategoryId = 1,
                    PositionId = 1,
                    PositionLevelId = 1,
                    RoleId = 3
                },

                new User(){
                    UserId = 3,
                    FirstName = "Dmitriy",
                    LastName = "Karabanovich",
                    UserName = "Dima",
                    DateOfBirth = new DateTime(1999,07,8),
                    DepartmentId = 1,
                    CategoryId = 1,
                    PositionId = 1,
                    PositionLevelId = 1,
                    RoleId = 3
                },
            };
            users.ForEach(u=>context.Users.AddOrUpdate(u));
            context.SaveChanges();
        }
    }
}
