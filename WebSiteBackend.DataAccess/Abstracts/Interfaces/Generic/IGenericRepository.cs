using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Entities.Abstracts.Interfaces;

namespace WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic
{
    public interface IGenericRepository<TEntity> 
        where TEntity : class, ITable, new()

    {


        #region Sync
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        List<TEntity> GetAllWithFilter(Expression<Func<TEntity, bool>> filter );
        List<TEntity> GetAll();
        TEntity GetByFilter(Expression<Func<TEntity, bool>> filter);
        TEntity GetByFilterAsNoTracking(Expression<Func<TEntity, bool>> filter);
        #endregion

        #region Async
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<List<TEntity>> GetAllWithFilterAsync(Expression<Func<TEntity, bool>> filter);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByFilterAsync(Expression<Func<TEntity, bool>> filter);
        
        #endregion



    }
}
