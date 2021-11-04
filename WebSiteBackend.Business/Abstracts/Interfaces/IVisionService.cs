using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.VisionDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
     public interface IVisionService
    {
        Task<ServiceResponse<VisionDto>> GetById(int id);
        Task<ServiceResponse<List<VisionDto>>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<List<VisionDto>>> GetAll();
        Task<ServiceResponse<int>> Create(VisionCreateDto dto);
        Task<ServiceResponse<bool>> Update(VisionUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
