using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Web.Core.Models
{
    public class GradeViewModel
    {
        public int GradeId { get; set; }

        public string Name { get; set; }

        public int? Level { get; set; }

        public string FullName
        {
            get { return Name + " " + Level; }
        }

    }
}
