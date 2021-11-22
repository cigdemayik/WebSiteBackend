using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.CarouselDtos;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface ICarouselService
    {
        Task<ServiceResponse<CarouselDto>> GetById(int id);
        Task<ServiceResponse<List<CarouselDto>>> GetAllByLanguage(int language);
        Task<ServiceResponse<List<CarouselDto>>> GetAll();
        Task<ServiceResponse<int>> Create(CarouselCreateDto dto);
        Task<ServiceResponse<bool>> Update(CarouselUpdateDto dto);
        Task<ServiceResponse<bool>> ChangeStatus(int id);
        Task<ServiceResponse<bool>> Delete(int id);
    }
}
