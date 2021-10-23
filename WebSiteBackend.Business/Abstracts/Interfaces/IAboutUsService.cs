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
        Task<ServiceResponse<List<AboutUsDto>>> GetAll();
        Task<ServiceResponse<AboutUsDto>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<bool>> Update(AboutUsUpdateDto dto);
        Task<ServiceResponse<AboutUsDto>> GetById(int id);
    }
}
