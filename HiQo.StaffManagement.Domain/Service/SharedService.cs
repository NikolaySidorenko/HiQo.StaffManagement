using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class SharedService:ISharedService
    {
        private readonly IDepartmentRepositiry _departmentRepositiry;
        private readonly IPositionLevelRepositiry _positionLevelRepositiry;
        private readonly IRoleRepositiry _roleRepositiry;
        private readonly ICategoryRepositiry _categoryRepositiry;
        private readonly IPositionRepositiry _positionRepositiry;

        public SharedService(IDepartmentRepositiry departmentRepositiry, IPositionLevelRepositiry positionLevelRepositiry,
            IRoleRepositiry roleRepositiry, ICategoryRepositiry categoryRepositiry, IPositionRepositiry positionRepositiry)
        {
            _departmentRepositiry = departmentRepositiry;
            _positionLevelRepositiry = positionLevelRepositiry;
            _roleRepositiry = roleRepositiry;
            _categoryRepositiry = categoryRepositiry;
            _positionRepositiry = positionRepositiry;
        }

        public SharedInfoDto GetSharedInfo()
        {
            SharedInfoDto info = new SharedInfoDto();
            info.Departments = _departmentRepositiry.GetAll<DepartmentDto>();
            info.Categories = _categoryRepositiry.GetAll<CategoryDto>();
            info.Positions = _positionRepositiry.GetAll<PositionDto>();
            info.Grades = _positionLevelRepositiry.GetAll<GradeDto>();
            info.Roles = _roleRepositiry.GetAll<RoleDto>();
            return info;
        }
    }
}
