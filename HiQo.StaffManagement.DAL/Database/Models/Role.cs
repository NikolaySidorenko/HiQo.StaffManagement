using System.Collections.Generic;

namespace HiQo.StaffManagement.DAL.Database.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public Role()
        {
            Users=new List<User>();
        }
    }
}
