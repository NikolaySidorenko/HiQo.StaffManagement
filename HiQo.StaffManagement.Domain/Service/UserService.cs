using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;

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
    }
}
