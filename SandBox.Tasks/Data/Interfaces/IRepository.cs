using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tasks.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> FindAllBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        T? FindSingleBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get();
        T? GetByID(object id);
    }
}
