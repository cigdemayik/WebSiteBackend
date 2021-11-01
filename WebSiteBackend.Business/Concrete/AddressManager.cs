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
        public async Task<ServiceResponse<List<AddressDto>>> GetAll()
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetAllByFilterAsync();
                var mappedData = data.ToList().Adapt<List<AddressDto>>();
                if (mappedData != null)
                    return _serviceResponseHelper.SetSuccess<List<AddressDto>>(mappedData, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<List<AddressDto>>(null, "Hiç Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<List<AddressDto>>(null, "Hakkımızda kayıtları getirilirken sorunla karşılaşıldı sırasında bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }

        public async Task<ServiceResponse<AddressDto>> GetAllByLanguage(LanguageEnum language)
        {
            try
            {
                var data = await _unitOfWork.GetRepository<Address>().GetByFilterAsync(x => x.Language == language);
                var dto = data.Adapt<AddressDto>();
                if (dto != null)
                    return _serviceResponseHelper.SetSuccess<AddressDto>(dto, System.Net.HttpStatusCode.OK);
                return _serviceResponseHelper.SetError<AddressDto>(null, "Hiç Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<AddressDto>(null, "Hakkımızda kayıtları getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
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
                return _serviceResponseHelper.SetError<AddressDto>(null, "Hakkımızda kaydı bulunamadı", System.Net.HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<AddressDto>(null, "Hakkımızda kaydı getirilirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
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
                return _serviceResponseHelper.SetError<bool>(data, "Hakkımızda güncelleme işlemi yapılamadı", System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                return _serviceResponseHelper.SetError<bool>(false, "Hakkımızda güncellenirken bir sorun ile karşılaşıldı.", System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
