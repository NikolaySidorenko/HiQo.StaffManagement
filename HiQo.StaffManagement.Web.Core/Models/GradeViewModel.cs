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
