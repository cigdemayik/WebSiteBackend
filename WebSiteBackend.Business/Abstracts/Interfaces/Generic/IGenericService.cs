using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.DataAccess.Abstracts.Interfaces;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces.Generic
{
    public interface IGenericService<TEntity> 
        where TEntity: class, ITable, new()
    {

        #region Sync
        ServiceResponse<TEntity> Create(TEntity entity);
        ServiceResponse Update(TEntity entity);
        ServiceResponse Delete(int id);
        ServiceResponse<List<TEntity>> GetAllWithFilter(Expression<Func<TEntity, bool>> filter);
        ServiceResponse<List<TEntity>> GetAll();
        ServiceResponse<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter);
        #endregion


        #region Async
        Task<ServiceResponse<TEntity>> CreateAsync(TEntity entity);
        Task<ServiceResponse>UpdateAsync(TEntity entity);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<ServiceResponse<List<TEntity>>> GetAllWithFilterAsync(Expression<Func<TEntity, bool>> filter);
        Task<ServiceResponse<TEntity>> GetAllAsync();
        Task<ServiceResponse<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter);

        #endregion

    }
}
