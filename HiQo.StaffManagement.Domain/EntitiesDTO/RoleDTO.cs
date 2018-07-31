using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class RoleDto
    {
        public int RoleId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }

        public RoleDto()
        {
            Users = new List<UserDto>();
        }
    }
}
