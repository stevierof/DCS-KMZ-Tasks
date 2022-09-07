using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tasks.Data.Interfaces
{
    interface IUnitOfWork
    {
        void Dispose();
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}
