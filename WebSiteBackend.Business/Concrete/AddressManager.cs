using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.AddressDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public AddressManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }
        public async Task<ServiceResponse<bool>> ChangeStatus(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetByFilterAsync(x => x.Id == id);
                data.Active = !data.Active;
                await _unitOfWork.SaveChangesAsync();
                return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Adres durumu değiştiriliyorken sorunla karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }
        public async Task<ServiceResponse<bool>> Delete(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetByFilterAsync(x => x.Id == id, null, Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking);
                var operation = await _unitOfWork.GetRepository<Address>().DeleteAsync(data);
                await _unitOfWork.SaveChangesAsync();
                if (operation)
                    return _serviceResponseHelper.SetSuccess<bool>(true, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(false, "Adres silinemedi", System.Net.HttpStatusCode.BadRequest);

            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Adres silinirken bir hata ile karşılaşıldı", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<List<AddressDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<AddressDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<AddressDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<AddressDto>>(null, "Hiç Adres kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<AddressDto>>(null, "Adres kayıtları getirilirken sorunla karşılaşıldı sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }

        }

        public async Task<ServiceResponse<List<AddressDto>>> GetAllByLanguage(LanguageEnum language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetAllByFilterAsync(x => x.Language == (int)language);
                var dto = data.ToList().Adapt<List<AddressDto>>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<List<AddressDto>>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<AddressDto>>(null, "Hiç Adres kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<AddressDto>>(null, "Adres kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<AddressDto>> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetByFilterAsync(x => x.Id == id);
                var dto = data.Adapt<AddressDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<AddressDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<AddressDto>(null, "Adres kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<AddressDto>(null, "Adres kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<AddressDto>> GetByLanguage(int language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetByFilterAsync(x => (int)x.Language == language);
                var mappedData = data.Adapt<AddressDto>();
                if (mappedData != null)
                {
                    return _serviceResponseHelper.SetSuccess<AddressDto>(mappedData, System.Net.HttpStatusCode.OK);
                }
                return _serviceResponseHelper.SetError<AddressDto>(null, "Adres Bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception)
            {

                return _serviceResponseHelper.SetError<AddressDto>(null, "Adres Getirilirken Bir Sorun ile Karşılaşıldı", System.Net.HttpStatusCode.BadRequest);
            }
        }

        public async Task<ServiceResponse<bool>> Update(AddressUpdateDto dto)
        {
            try
            {
                var mappedData = dto.Adapt<Address>();
                var data = await _unitOfWork.GetRepository<Address>().UpdateAsync(mappedData);
                await _unitOfWork.SaveChangesAsync();
                if (data)
                    return _serviceResponseHelper.SetSuccess<bool>(data, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<bool>(data, "Adres güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Adres güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
