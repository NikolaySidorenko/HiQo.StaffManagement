using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class UserRepository:BaseRepository, IUserRepositiry
    {
        private DbSet<User> _dbSet;

        public UserRepository(CompanyContext dbContext):base(dbContext)
        {
            _dbSet = dbContext.Set<User>();
        }
    }
}
