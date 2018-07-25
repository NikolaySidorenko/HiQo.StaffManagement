﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Domain.EntitiesDTO
{
    public class RoleDto
    {
        public int RoleId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }

        public RoleDto()
        {
            Users = new List<UserDto>();
        }
    }
}
