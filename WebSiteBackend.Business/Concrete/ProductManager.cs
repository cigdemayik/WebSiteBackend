using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.ProductDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public ProductManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public Task<ServiceResponse<int>> Create(ProductCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<ProductDto>>> GetAllByLanguage(LanguageEnum language)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<ProductDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> Update(ProductUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
