using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Aspect;
using WebSiteBackend.Business.Aspect.AspectMarker;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.CrossCutttingConcerns;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    [BusinessLogAspect]
    public class BlogManager : IBlogService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public BlogManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
            
        }

        public async Task<ServiceResponse<bool>> Delete(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Blog>().GetByFilterAsync(x => x.Id == id,null,Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking);
                var operation = await _unitOfWork.GetRepository<Blog>().DeleteAsync(data);
                await _unitOfWork.SaveChangesAsync();
                if (operation)
                    return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(false, "Blog silinemedi", System.Net.HttpStatusCode.BadRequest);

            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false,"Blog silinirken bir hata ile karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<bool>> ChangeStatus(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Blog>().GetByFilterAsync(x => x.Id==id);
                data.Active = !data.Active;
                await _unitOfWork.SaveChangesAsync();
                return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false,"Blog durumu değiştiriliyorken sorunla karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<int>> Create(BlogCreateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Blog>();
                var category = await _unitOfWork.GetRepository<Category>().GetByFilterAsync(x => x.Id == dto.CategoryId);
                mappedData.Language = (int)category.Language;
                var result = await _unitOfWork.GetRepository<Blog>().AddAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (result != null)
                    return _serviceResponseHelper.SetSuccess<int>(result.Id, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<int>(-1, "Blog ekleme işlemi başarısız", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return _serviceResponseHelper.SetError<int>(0, "Blog Ekleme sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<List<BlogDto>>> GetAll()
        {
            try
            {
                var includes = new List<Expression<Func<Blog, object>>>();
                includes.Add(x => x.Category);
                var data = await _unitOfWork.GetRepository<Blog>().GetAllByFilterAsync(null, includes.ToArray());
                var mappedData = data.ToList().Adapt<List<BlogDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<BlogDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<BlogDto>>(null, "Hiç Blog kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<List<BlogDto>>(null, "Blog Getirme sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        [BusinessLogAspect]
        public async Task<ServiceResponse<List<BlogDto>>> GetAllByLanguage(int language)
        {
            try
            {
                var includes = new List<Expression<Func<Blog, object>>>();
                includes.Add(x => x.Category);
                var data = await _unitOfWork.GetRepository<Blog>().GetAllByFilterAsync(x => x.Language == (int)language, includes.ToArray());
                var dto = data.ToList().Adapt<List<BlogDto>>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<List<BlogDto>>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<BlogDto>>(null, "Hiç Blog kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<BlogDto>>(null, "Blog kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<BlogDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Blog>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<BlogDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<BlogDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<BlogDto>(null, "Blog kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<BlogDto>(null, "Blog kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<bool>> Update(BlogUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Blog>();
                var category = await _unitOfWork.GetRepository<Category>().GetByFilterAsync(x => x.Id == dto.CategoryId);
                mappedData.Language = (int)category.Language;
                var data = await _unitOfWork.GetRepository<Blog>().UpdateAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (data)
                    return _serviceResponseHelper.SetSuccess<bool>(data, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(data, "Blog güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Blog güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<BlogDto>> GetByLanguage(int language)
        {
            try
            {
                var includes = new List<Expression<Func<Blog, object>>>();

                includes.Add(x => x.Category);
                
                var data = await _unitOfWork.GetRepository<Blog>()
                    .GetByFilterAsync(x => (int)x.Language == language && x.Active,
                    includes.ToArray(),
                    Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking,
                    false);
                var mappedData = data.Adapt<BlogDto>();
                if (mappedData != null)
                {
                    return _serviceResponseHelper.SetSuccess<BlogDto>(mappedData, System.Net.HttpStatusCode.OK);
                    
                }
                return _serviceResponseHelper.SetError<BlogDto>(null, "Blog Bulunamadı", System.Net.HttpStatusCode.NotFound);

            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<BlogDto>(null, "Blog Getirilirken Bir Hata ile KArşılaşıldı", System.Net.HttpStatusCode.BadRequest);
            };
        }
    }
}
