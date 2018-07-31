using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class SharedInfoDto
    {
        public IEnumerable<DepartmentDto> Departments { get; set; }

        public IEnumerable<CategoryDto> Categories { get; set; }

        public IEnumerable<GradeDto> Grades { get; set; }

        public IEnumerable<PositionDto> Positions { get; set; }

        public IEnumerable<RoleDto> Roles { get; set; }

    }
}
