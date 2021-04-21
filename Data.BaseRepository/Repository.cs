using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DbSet<T> Table { get; set; }
        public Repository(DbContext context)
        {
            Table = context.Set<T>();
        }

        public T Get(int id)
        {
            return Table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Table.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Table.SingleOrDefault(predicate);
        }

        public void Add(T entity)
        {
            Table.Add(entity);
        }

        public void AddRange(IList<T> entities)
        {
            Table.AddRange(entities);
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Table.RemoveRange(entities);
        }

        public IList<T> GetList()
        {
            return Table.ToList();
        }
    }
}
