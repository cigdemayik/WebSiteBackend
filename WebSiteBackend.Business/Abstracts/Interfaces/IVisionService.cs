using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.VissionMissionDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
     public interface IVisionService
    {
        Task<ServiceResponse<List<VisionDto>>> GetAll();
        Task<ServiceResponse<VisionDto>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<bool>> Update(VisionUpdateDto dto);
        Task<ServiceResponse<VisionDto>> GetById(int id);
    }
}
