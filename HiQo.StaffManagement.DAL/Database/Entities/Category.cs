using System.Collections.Generic;

namespace HiQo.StaffManagement.DAL.Database.Entities
{
    
    public class Category
    {

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Position> Positions { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public Category()
        {
            Positions = new List<Position>();
            Users = new List<User>();
        }

    }
}
