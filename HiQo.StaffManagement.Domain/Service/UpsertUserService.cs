using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class UpsertUserService:IUpsertUserService
    {
        private IUserRepositiry _userRepositiry;
        private ICategoryService _categoryService;
        private IPositionService _positionService;
        private ISharedService _sharedService;

        public UpsertUserService(IUserRepositiry userRepositiry, ICategoryService categoryService, IPositionService positionService, ISharedService sharedService)
        {
            _userRepositiry = userRepositiry;
            _categoryService = categoryService;
            _positionService = positionService;
            _sharedService = sharedService;
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _userRepositiry.GetAll<UserDto>();
        }

        public UserDto GetById(int id)
        {
            return _userRepositiry.GetById<UserDto>(id);
        }

        public void Create(UserDto user)
        {
            _userRepositiry.Create(user);
            _userRepositiry.SaveChanges();
        }

        public void Update(UserDto user)
        {
           _userRepositiry.Update(user);
           _userRepositiry.SaveChanges();
        }

        public IEnumerable<CategoryDto> GetCategoriesByDepartmentId(int id)
        {
            return _categoryService.GetByDepartmentId(id);
        }

        public IEnumerable<PositionDto> GetPositinsByCategoryId(int id)
        {
            return _positionService.GetByCategoryId(id);
        }

        public SharedInfoDto GetSharedInfo()
        {
            return _sharedService.GetSharedInfo();
        }
    }
}
