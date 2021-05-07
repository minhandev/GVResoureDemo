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
        }

        public void SaveChanges()
        {
             context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IQueryable<TEntity> CreateQueryable<TEntity>() where TEntity : class
        {
            return context.Set<TEntity>().AsQueryable();
        }
    }
}
