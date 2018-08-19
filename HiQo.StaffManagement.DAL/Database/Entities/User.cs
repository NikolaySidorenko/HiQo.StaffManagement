using System;
using Microsoft.AspNet.Identity;

namespace HiQo.StaffManagement.DAL.Database.Entities
{
    public class User : IUser<int>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime DateOfBirth { get; set; }
    

        public int RoleId { get; set; }
        
        public virtual Role Role { get; set; }
    

        public int PositionId { get; set; }

        public virtual Position Position { get; set; }


        public int PositionLevelId { get; set; }

        public virtual PositionLevel PositionLevel { get; set; }


        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }


        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public User()
        {
            
        }
    }
}
