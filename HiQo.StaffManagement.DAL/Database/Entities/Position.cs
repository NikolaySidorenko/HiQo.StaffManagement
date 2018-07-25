using System.Collections.Generic;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Database.Entities
{
    public class Position
    {
        public int PositionId { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    
        public virtual ICollection<User> Users { get; set; }

        public Position()
        {
            Users=new List<User>();
        }
    }
}
