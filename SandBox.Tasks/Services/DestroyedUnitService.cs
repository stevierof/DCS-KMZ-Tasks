using SandBox.Tasks.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SandBox.Tasks.Data.Entities;
using SandBox.Tasks.Data;
using Microsoft.EntityFrameworkCore;

namespace SandBox.Tasks.Services
{
    public class DestroyedUnitService
    {
        IUnitOfWork _uow;
        IRepository<DestroyedUnit>? _repository;

        public DestroyedUnitService(DbContext context)
        {
            _uow = new UnitOfWork(context);
            _repository = _uow.Repository<DestroyedUnit>();

        }

        public List<DestroyedUnit>? Fetch(string missionId)
        {
            return _repository?.FindAllBy(x => x.MissionId == missionId).ToList();
        }
    }
}
