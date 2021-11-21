using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;
        public CategoryManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public async Task<ServiceResponse<bool>> Delete(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Category>().GetByFilterAsync(x => x.Id == id, null, Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking);
                var operation = await _unitOfWork.GetRepository<Category>().DeleteAsync(data);
                await _unitOfWork.SaveChangesAsync();
                if (operation)
                    return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(false, "Kategori silinemedi", System.Net.HttpStatusCode.BadRequest);

            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Kategori silinirken bir hata ile karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        public async Task<ServiceResponse<bool>> ChangeStatus(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Category>().GetByFilterAsync(x => x.Id == id);
                data.Active = !data.Active;
                await _unitOfWork.SaveChangesAsync();
                return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Kategori durumu değiştiriliyorken sorunla karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        public async Task<ServiceResponse<int>> Create(CategoryCreateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Category>();
                var result = await _unitOfWork.GetRepository<Category>().AddAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (result != null)
                    return _serviceResponseHelper.SetSuccess<int>(result.Id, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<int>(-1, "Kategori ekleme işlemi başarısız", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return _serviceResponseHelper.SetError<int>(0, "Kategori Ekleme sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<List<CategoryDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Category>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<CategoryDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<CategoryDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<CategoryDto>>(null, "Hiç kategori kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<List<CategoryDto>>(null, "Kategori Ekleme sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<List<CategoryDto>>> GetAllByLanguage(int language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Category>().GetAllByFilterAsync(x => x.Language == (int)language);
                var dto = data.ToList().Adapt<List<CategoryDto>>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<List<CategoryDto>>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<CategoryDto>>(null, "Hiç kategori kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<CategoryDto>>(null, "Kategori kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<CategoryDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Category>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<CategoryDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<CategoryDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<CategoryDto>(null, "Kategori kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<CategoryDto>(null, "Kategori kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<bool>> Update(CategoryUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Category>();
                var data = await _unitOfWork.GetRepository<Category>().UpdateAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (data)
                    return _serviceResponseHelper.SetSuccess<bool>(data, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(data, "Kategori güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Kategori güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
