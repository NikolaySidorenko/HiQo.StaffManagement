using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.Domain.Service
{
    class UserService: IUserService
    {
        private IUserRepositiry _userRepository;

        public UserService(IUserRepositiry userRepository)
        {
            _userRepository = userRepository;
        }

        public TEntitiy GetByUserName<TEntitiy>(string userName) where TEntitiy : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByDepartment<TEntity>(string department) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByCategory<TEntity>(string category) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByPosition<TEntity>(string position) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByPositionLevel<TEntity>(string positionLevel) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByRole<TEntity>(string role) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByAge<TEntity>(int age) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
