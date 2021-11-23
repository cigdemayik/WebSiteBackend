using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Aspect;
using WebSiteBackend.Business.Dtos.ProductDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    [BusinessAspect]
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public ProductManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public async Task<ServiceResponse<bool>> Delete(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Product>().GetByFilterAsync(x => x.Id == id, null, Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking);
                var operation = await _unitOfWork.GetRepository<Product>().DeleteAsync(data);
                await _unitOfWork.SaveChangesAsync();
                if (operation)
                    return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(false, "Ürün silinemedi", System.Net.HttpStatusCode.BadRequest);

            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Ürün silinirken bir hata ile karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        public async Task<ServiceResponse<bool>> ChangeStatus(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Product>().GetByFilterAsync(x => x.Id == id);
                data.Active = !data.Active;
                await _unitOfWork.SaveChangesAsync();
                return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Ürün durumu değiştiriliyorken sorunla karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        public async Task<ServiceResponse<int>> Create(ProductCreateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Product>();
                var result = await _unitOfWork.GetRepository<Product>().AddAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (result != null)
                    return _serviceResponseHelper.SetSuccess<int>(result.Id, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<int>(-1, "Ürün ekleme işlemi başarısız", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return _serviceResponseHelper.SetError<int>(0, "Ürün Ekleme sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }

        }

        public async Task<ServiceResponse<List<ProductDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Product>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<ProductDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<ProductDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<ProductDto>>(null, "Hiç ürün kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<List<ProductDto>>(null, "Ürün Ekleme sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }

        }
        public async Task<ServiceResponse<List<ProductDto>>> GetAllByLanguage(int language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Product>().GetAllByFilterAsync(x => (int)x.Language == language);
                var dto = data.ToList().Adapt<List<ProductDto>>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<List<ProductDto>>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<ProductDto>>(null, "Hiç ürün kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<ProductDto>>(null, "Ürün kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
            
        }

        public async Task<ServiceResponse<ProductDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Product>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<ProductDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<ProductDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<ProductDto>(null, "Ürün kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<ProductDto>(null, "Ürün kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
            
        }

        public async Task<ServiceResponse<bool>> Update(ProductUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Product>();
                var data = await _unitOfWork.GetRepository<Product>().UpdateAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (data)
                    return _serviceResponseHelper.SetSuccess<bool>(data, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(data, "Ürün güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Ürün güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
            
        }
    }
}
