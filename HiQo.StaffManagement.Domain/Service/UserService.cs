using System;
using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepositiry _repositiry;

        public UserService(IUserRepositiry userRepository)
        {
            _repositiry = userRepository;
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _repositiry.GetAll<UserDto>();
        }

        public UserDto GetById(int id)
        {
            return _repositiry.GetById<UserDto>(id);
        }

        public void Update(UserDto user)
        {
            _repositiry.Update(user);
            _repositiry.SaveChanges();
        }

        
        
    }
}
