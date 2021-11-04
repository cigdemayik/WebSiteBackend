using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.AddressDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IAddressService
    {
        Task<ServiceResponse<AddressDto>> GetById(int id);
        Task<ServiceResponse<List<AddressDto>>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<List<AddressDto>>> GetAll();
        Task<ServiceResponse<int>> Create(AddressCreateDto dto);
        Task<ServiceResponse<bool>> Update(AddressUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
