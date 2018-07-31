using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class GradeService:IGradeService
    {
        private readonly IPositionLevelRepositiry _repositiry;

        public GradeService(IPositionLevelRepositiry repositiry)
        {
            _repositiry = repositiry;
        }

        public IEnumerable<GradeDto> GetAll()
        {
            return _repositiry.GetAll<GradeDto>();
        }

        public GradeDto GetById(int id)
        {
            return _repositiry.GetById<GradeDto>(id);
        }
    }
}
