using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public virtual DepartmentDto Department { get; set; }

        public virtual ICollection<PositionDto> Positions { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }


        public CategoryDto()
        {
            Positions = new List<PositionDto>();
            Users = new List<UserDto>();
        }
    }
}
