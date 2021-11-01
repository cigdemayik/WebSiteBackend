using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.MissionDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IMissionService
    {
        Task<ServiceResponse<List<MissionDto>>> GetAll();
        Task<ServiceResponse<MissionDto>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<bool>> Update(MissionUpdateDto dto);
        Task<ServiceResponse<MissionDto>> GetById(int id);
    }
}
