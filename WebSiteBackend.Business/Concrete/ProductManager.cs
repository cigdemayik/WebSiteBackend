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
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Product> generic;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public ProductManager(IUnitOfWork unitOfWork, IGenericRepository<Product> generic, IServiceResponseHelper serviceResponseHelper) 
            : base(unitOfWork, generic, serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            this.generic = generic;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public ServiceResponse<Product> GetById(int id)
        {
            var data = _unitOfWork.Products.GetByFilter(x => x.Id == id);
            if (data == null)
            {
                return _serviceResponseHelper.SetError<Product>(data, "Product Bulunamadı", HttpStatusCode.NotFound);
            }
            else
            {
                return _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
            }
        }
    }
}
