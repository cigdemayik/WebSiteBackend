using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.AboutUsDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IAboutUsService
    {
        Task<ServiceResponse<AboutUsDto>> GetById(int id);
        Task<ServiceResponse<List<AboutUsDto>>> GetAllByLanguage(int language);
        Task<ServiceResponse<List<AboutUsDto>>> GetAll();
        Task<ServiceResponse<AboutUsDto>> GetByLanguage(int language);
        Task<ServiceResponse<bool>> Update(AboutUsUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
