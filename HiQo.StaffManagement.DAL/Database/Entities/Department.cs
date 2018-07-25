using System.Collections.Generic;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Database.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public Department()
        {
            Categories=new List<Category>();
            Users=new List<User>();
        }
    }
}
