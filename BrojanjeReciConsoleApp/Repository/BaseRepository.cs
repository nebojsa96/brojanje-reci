using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BrojanjeReciConsoleApp.Repository
{
    public class BaseRepository<TEntity, TContext> : IRepository<TEntity>
           where TEntity : class
           where TContext : DbContext
    {
        internal DbContext _dbContext;
        internal DbSet<TEntity> dbSet;

        public BaseRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this.dbSet = _dbContext.Set<TEntity>();
        }

        protected TContext GetCurrentContext
        {
            get
            {
                if (this._dbContext != null)
                {
                    return (TContext)_dbContext;
                }
                return null;
            }
        }


        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual async Task<TEntity> GetByIDAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

    }
}
