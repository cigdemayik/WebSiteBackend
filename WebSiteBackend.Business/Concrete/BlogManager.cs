using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Concrete.Generic;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;

namespace WebSiteBackend.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public BlogManager(IUnitOfWork unitOfWork, IGenericRepository<Blog> generic, IServiceResponseHelper serviceResponseHelper) : base(unitOfWork, generic, serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public Blog GetById(int id)
        {
            return _unitOfWork.Blogs.GetByFilter(x => x.Id == id);
        }
    }
}
