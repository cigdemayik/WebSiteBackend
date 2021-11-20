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
        Task<ServiceResponse<MissionDto>> GetById(int id);
        Task<ServiceResponse<List<MissionDto>>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<List<MissionDto>>> GetAll();
        Task<ServiceResponse<bool>> Update(MissionUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
