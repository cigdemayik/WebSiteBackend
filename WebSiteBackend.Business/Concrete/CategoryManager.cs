using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;
        public CategoryManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public Task<ServiceResponse<int>> Create(CategoryCreateDto dto)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<CategoryDto>>> GetAllByLanguage(LanguageEnum language)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<CategoryDto>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<bool>> Update(CategoryUpdateDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
