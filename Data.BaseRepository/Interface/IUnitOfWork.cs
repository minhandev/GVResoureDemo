using Data.Entity;
using Data.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IQueryable<TEntity> CreateQueryable<TEntity>() where TEntity : class;
    }
}
