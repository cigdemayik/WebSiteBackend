using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Concrete.Generic;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;


        public CategoryManager(IUnitOfWork unitOfWork, IGenericRepository<Category> generic, IServiceResponseHelper serviceResponseHelper)
            : base(unitOfWork, generic, serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public ServiceResponse<Category> GetById(int id)
        {
            var data = _unitOfWork.Categories.GetByFilter(x => x.Id == id);
            if (data == null)
            {
                return _serviceResponseHelper.SetError<Category>(data, "Category Bulunamadı", HttpStatusCode.NotFound);
            }
            else
            {
                return _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
            }
        }
    }
}
