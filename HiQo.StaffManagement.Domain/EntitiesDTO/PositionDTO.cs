using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
