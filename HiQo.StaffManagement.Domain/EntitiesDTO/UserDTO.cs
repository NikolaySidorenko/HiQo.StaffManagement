using System;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

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
