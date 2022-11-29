using DataAccess.DataInterface;
using IGames.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataImplemntation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        internal DbSet<T> Set;
        public Repository (ApplicationDbContext db)
            {
                _db= db;
            this.Set=  _db.Set<T>();
            }
        IRepository<T> IRepository<T>.Repository => throw new NotImplementedException();

        public void Add(T entity)
        {
            _db.Add(entity);
        }

        public IEnumerable<T>GetAll()
        {
            IQueryable<T> query = Set;
            return query.ToList();
        }

        public T getFirstOrDefualt(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = Set;
            query= query.Where(predicate);
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            Set.Remove(entity);
            
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            Set.RemoveRange(entity);
        }
    }
}
