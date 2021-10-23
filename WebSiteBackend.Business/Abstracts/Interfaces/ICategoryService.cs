using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface ICategoryService
    {
        Task<ServiceResponse<CategoryDto>> GetById(int id);
        Task<ServiceResponse<List<CategoryDto>>> GetAllByLanguage(LanguageEnum language);
        Task<ServiceResponse<List<CategoryDto>>> GetAll();
        Task<ServiceResponse<int>> Create(CategoryCreateDto dto);
        Task<ServiceResponse<bool>> Update(CategoryUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
