using System;
using Microsoft.AspNet.Identity;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class UserDto : IUser<int>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Salt { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int DepartmentId { get; set; }

        public DepartmentDto Department { get; set; }

        public int PositionId { get; set; }

        public PositionDto Position { get; set; }

        public int CategoryId { get; set; }

        public CategoryDto Category { get; set; }
 
        public int GradeId { get; set; }

        public GradeDto Grade { get; set; }

        public int RoleId { get; set; }

        public RoleDto Role { get; set; }


        public UserDto()
        {

        }
    }
}
