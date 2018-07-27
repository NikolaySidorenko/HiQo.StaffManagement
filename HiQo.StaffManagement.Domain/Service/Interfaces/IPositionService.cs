using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service.Interfaces
{
    public interface IPositionService
    {
        IEnumerable<PositionDto> GetAll();
        PositionDto GetById(int id);
        IEnumerable<PositionDto> GetByCategoryId(int id);
    }
}
