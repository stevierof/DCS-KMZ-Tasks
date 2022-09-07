using SandBox.Tasks.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SandBox.Tasks.Data.Entities;
using SandBox.Tasks.Data;
using Microsoft.EntityFrameworkCore;
#pragma warning disable CS8603 // Possible null reference return.

namespace SandBox.Tasks.Services
{
    public class ReconnedUnitService
    {
        IUnitOfWork _uow;
        IRepository<ReconnedUnit>? _repository;

        public ReconnedUnitService(DbContext context)
        {
            _uow = new UnitOfWork(context);
            _repository = _uow.Repository<ReconnedUnit>();

        }

        public async Task<IEnumerable<ReconnedUnit>>? Fetch(string missionId)
        {

            return await Task.Run(() =>
            {
                return Task.FromResult(_repository?.FindAllBy(x => x.MissionId == missionId));
            });

        }
    }
}
