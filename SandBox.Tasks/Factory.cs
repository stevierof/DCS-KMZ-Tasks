using Microsoft.EntityFrameworkCore;
using SandBox.Tasks.Data;
using SandBox.Tasks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618
namespace SandBox.Tasks
{
    public class Factory
    {
        DbContext _context;

        private DestroyedUnitService _destroyedUnitService;
        public DestroyedUnitService? DestroyedUnitService
        {
            get
            {
                if (_destroyedUnitService == null)
                    _destroyedUnitService = new DestroyedUnitService(_context);
                return _destroyedUnitService;
            }
        }

        private ReconnedUnitService _reconnedUnitService;
        public  ReconnedUnitService? ReconnedUnitService
        {
            get
            {
                if (_reconnedUnitService == null)
                    _reconnedUnitService = new ReconnedUnitService(_context);
                return _reconnedUnitService;
            }
        }


        public Factory(SandBoxContext context)
        {
            _context = context;
        }


    }
}
