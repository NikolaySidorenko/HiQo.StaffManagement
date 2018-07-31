using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class PositionDto
    {
        public int PositionId { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual CategoryDto Category { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }

        public PositionDto()
        {
            Users = new List<UserDto>();
        }
    }
}
