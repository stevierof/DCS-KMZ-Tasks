using Microsoft.EntityFrameworkCore;
using SandBox.Tasks.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tasks.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private DbContext _context;
        private DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }

        public virtual IEnumerable<T> Get()
        {
            IQueryable<T> query = _dbSet;
            return query.ToList();
        }

        public virtual T? FindSingleBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).FirstOrDefault();
        }

        public virtual IQueryable<T> FindAllBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public virtual T GetByID(object id)
        {
            return _dbSet.Find(id)!;
        }

    }
}
