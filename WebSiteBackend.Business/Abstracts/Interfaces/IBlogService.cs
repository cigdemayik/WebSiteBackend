using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IBlogService
    {
        Task<ServiceResponse<BlogDto>> GetById(int id);
        Task<ServiceResponse<List<BlogDto>>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<List<BlogDto>>> GetAll();
        Task<ServiceResponse<BlogDto>> GetByLanguage(int language);
        Task<ServiceResponse<int>> Create(BlogCreateDto dto);
        Task<ServiceResponse<bool>> Update(BlogUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
