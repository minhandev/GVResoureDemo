using Data.Entity;
using Data.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext context { get; internal set; }

        public UnitOfWork(GvResourceContext _context)
        {
            context = _context;
            #region Phân vùng IRepository theo Context
            //Product = new Repository<Product>(context);

            //Match = new Repository<Match>(context);
            #endregion
        }

        #region Phân vùng IRepository theo Model
        //public IRepository<Product> Product { get; }
        //public IRepository<Match> Match { get; }
        #endregion

        public void Commit()
        {
             context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<TEntity> Queryable<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>().AsQueryable();
        }
    }
}
