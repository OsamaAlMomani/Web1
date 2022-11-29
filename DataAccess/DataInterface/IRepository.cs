using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataInterface
{
    public interface IRepository <T> where T : class
    {
        public IRepository<T> Repository { get;}
        public IEnumerable<T> GetAll ();
        public void Add (T entity);
        public void Remove (T entity);
        public void RemoveRange (IEnumerable<T>entity);
        public T getFirstOrDefualt(Expression<Func<T, bool>> predicate);
    }
}
