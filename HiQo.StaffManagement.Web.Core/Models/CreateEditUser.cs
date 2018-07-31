using System;
using System.ComponentModel.DataAnnotations;

namespace HiQo.StaffManagement.Web.Core.Models
{
    public class CreateEditUser
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public int DepartmentId { get; set; }

        public int PositionId { get; set; }

        public int CategoryId { get; set; }

        public int GradeId { get; set; }

        public int RoleId { get; set; }

    }
}