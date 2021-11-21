using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.NewsDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface INewsService
    {
        Task<ServiceResponse<NewsDto>> GetById(int id);
        Task<ServiceResponse<List<NewsDto>>> GetAllByLanguage(int language);
        Task<ServiceResponse<List<NewsDto>>> GetAll();
        Task<ServiceResponse<int>> Create(NewsCreateDto dto);
        Task<ServiceResponse<bool>> Update(NewsUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
