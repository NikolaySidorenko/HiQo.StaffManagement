using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }

        public virtual ICollection<CategoryDto> Categories { get; set; }

        public DepartmentDto()
        {
            Categories = new List<CategoryDto>();
            Users = new List<UserDto>();
        }
    }
}
