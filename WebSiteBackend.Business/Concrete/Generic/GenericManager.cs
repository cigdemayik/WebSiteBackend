
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete.Generic
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<TEntity> _generic;
        private readonly IServiceResponseHelper _serviceResponseHelper;
        public GenericManager(IUnitOfWork unitOfWork, IGenericRepository<TEntity> generic, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            _generic = generic;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public ServiceResponse<TEntity> Create(TEntity entity)
        {
            try
            {
                _generic.Create(entity);
                _unitOfWork.SaveChanges();
                var response =_serviceResponseHelper.SetSuccess(entity, HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError(entity, ex.Message, HttpStatusCode.NotFound);
            }
            
        }

        public async Task<ServiceResponse<TEntity>> CreateAsync(TEntity entity)
        {
            try
            {
                await _generic.CreateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
                var response = _serviceResponseHelper.SetSuccess(entity, HttpStatusCode.OK);
                return response;
            }
            catch(Exception ex)
            {
                return _serviceResponseHelper.SetError(entity, ex.Message, HttpStatusCode.NotFound);
            }
        }

        public ServiceResponse Delete(int id)
        {
            try
            {
                _generic.Delete(id);
                _unitOfWork.SaveChanges();
                var response = _serviceResponseHelper.SetSuccess(HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError(ex.Message, HttpStatusCode.NotFound);
            }
            
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            try
            {
                await _generic.DeleteAsync(id);
                await _unitOfWork.SaveChangesAsync();
                var response = _serviceResponseHelper.SetSuccess(HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError(ex.Message, HttpStatusCode.NotFound);
            }
            
        }

        public ServiceResponse<List<TEntity>> GetAll()
        {
            try
            {
                var data = _generic.GetAll();
                var response = _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {
                var response = _serviceResponseHelper.SetError<List<TEntity>>(null, errorMessage:ex.Message,
                    HttpStatusCode.NotFound);
                return response;
            }
        }
        
        public async Task<ServiceResponse<List<TEntity>>> GetAllAsync()
        {
            try
            {
                var data = await _generic.GetAllAsync().ConfigureAwait(false);
                var response = _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {
                var response = _serviceResponseHelper.SetError<List<TEntity>>(null, errorMessage: ex.Message,HttpStatusCode.NotFound);
                return response;
            }            
        }

        public ServiceResponse<List<TEntity>> GetAllWithFilter(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                var data = _generic.GetAllWithFilter(filter);
                var response = _serviceResponseHelper.SetSuccess(data,HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                var response = _serviceResponseHelper.SetError<List<TEntity>>(null, errorMessage:ex.Message,HttpStatusCode.NotFound);
                return response;
            }
            
        }

        public async Task<ServiceResponse<List<TEntity>>> GetAllWithFilterAsync(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                var data= await _generic.GetAllWithFilterAsync(filter);
                var response = _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                var response = _serviceResponseHelper.SetError<List<TEntity>>(null, errorMessage:ex.Message, HttpStatusCode.NotFound);
                return response;
            } 
        }

        public ServiceResponse<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                var data= _generic.GetByFilter(filter);
                var response = _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                var response = _serviceResponseHelper.SetError<TEntity>(null, errorMessage: ex.Message, HttpStatusCode.NotFound);
                return response;
            }
        }

        public async Task<ServiceResponse<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                var data = await _generic.GetByFilterAsync(filter);
                var response = _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                var response = _serviceResponseHelper.SetError<TEntity>(null, errorMessage: ex.Message, HttpStatusCode.NotFound);
                return response;
            }
        }

        public ServiceResponse Update(TEntity entity)
        {
            try
            {
                _generic.Update(entity);
                _unitOfWork.SaveChanges();
                var response = _serviceResponseHelper.SetSuccess(HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError(ex.Message, HttpStatusCode.NotFound);
            }
        }

        public async Task<ServiceResponse> UpdateAsync(TEntity entity)
        {
            try
            {
                await _generic.UpdateAsync(entity);
                await _unitOfWork.SaveChangesAsync();
                var response = _serviceResponseHelper.SetSuccess(HttpStatusCode.OK);
                return response;
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError(ex.Message, HttpStatusCode.NotFound);
            }
        }
    }
}
