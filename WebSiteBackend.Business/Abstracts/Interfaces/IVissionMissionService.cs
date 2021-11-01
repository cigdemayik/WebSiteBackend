using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.VissionMissionDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
     public interface IVissionMissionService
    {
        Task<ServiceResponse<List<VissionMissionDto>>> GetAll();
        Task<ServiceResponse<VissionMissionDto>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<bool>> Update(VissionMissionUpdateDto dto);
        Task<ServiceResponse<VissionMissionDto>> GetById(int id);
    }
}
