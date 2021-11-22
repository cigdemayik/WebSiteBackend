using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.ProductDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IProductService
    {
        Task<ServiceResponse<ProductDto>> GetById(int id);
        Task<ServiceResponse<List<ProductDto>>> GetAllByLanguage(int language);
        Task<ServiceResponse<List<ProductDto>>> GetAll();
        Task<ServiceResponse<int>> Create(ProductCreateDto dto);
        Task<ServiceResponse<bool>> Update(ProductUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
