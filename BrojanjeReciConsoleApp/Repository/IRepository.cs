using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BrojanjeReciConsoleApp.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(object id);
        Task<TEntity> GetByIDAsync(object id);

    }
}
