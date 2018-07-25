using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class GradeDto
    {
        public int GradeId { get; set; }

        public string Name { get; set; }

        public int? Level { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }

        public GradeDto()
        {
            Users = new List<UserDto>();
        }
    }
}
