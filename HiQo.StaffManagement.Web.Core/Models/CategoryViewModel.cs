using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Web.Core.Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }

        public int Name { get; set; }

        public int DepartmentId { get; set; }

        public SharedInfoDto SharedInfo { get; set; }
    }
}
