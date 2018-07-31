using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service.Interfaces
{
    public interface IGradeService
    {
        IEnumerable<GradeDto> GetAll();
        GradeDto GetById(int id);
    }
}
