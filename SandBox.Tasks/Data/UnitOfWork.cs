using Microsoft.EntityFrameworkCore;
using SandBox.Tasks.Data.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8603 // Possible null reference return.
namespace SandBox.Tasks.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly DbContext _context;

        private bool _disposed;
        private Hashtable? _repositories;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();

            _disposed = true;
        }


        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (_repositories.ContainsKey(type))
                
                return (IRepository<TEntity>)_repositories[type];

            var repositoryType = typeof(Repository<>);

            var repositoryInstance =
                Activator.CreateInstance(repositoryType
                    .MakeGenericType(typeof(TEntity)), _context);

            _repositories.Add(type, repositoryInstance);

            return (IRepository<TEntity>)_repositories[type];
        }
    }
}
