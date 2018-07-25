using System.Collections.Generic;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Database.Entities
{
    public class PositionLevel
    {
        public int PositionLevelId { get; set; }

        public string Name { get; set; }

        public int? Level { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public PositionLevel()
        {
            Users = new List<User>();
        }
    }
}
