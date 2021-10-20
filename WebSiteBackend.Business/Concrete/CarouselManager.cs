using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.CarouselDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class CarouselManager : ICarouselService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public CarouselManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public Task<ServiceResponse<int>> Create(CarouselCreateDto dto)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<CarouselDto>>> GetAllByLanguage(LanguageEnum language)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<CarouselDto>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<bool>> Update(CarouselUpdateDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
