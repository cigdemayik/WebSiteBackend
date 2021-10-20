using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public BlogManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceResponseHelper = serviceResponseHelper ?? throw new ArgumentNullException(nameof(serviceResponseHelper));
        }

        public Task<ServiceResponse<int>> Create(BlogCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<BlogDto>>> GetAllByLanguage(LanguageEnum language)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BlogDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> Update(BlogUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
