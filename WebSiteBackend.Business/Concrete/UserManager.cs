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
    public class UserManager : GenericManager<User>, IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public UserManager(IUnitOfWork unitOfWork, IGenericRepository<User> generic, IServiceResponseHelper serviceResponseHelper) : base(unitOfWork, generic, serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public ServiceResponse<User> GetById(int id)
        {
            var data = _unitOfWork.Users.GetByFilter(x => x.Id == id);
            if (data == null)
            {
                return _serviceResponseHelper.SetError<User>(data, "Product Bulunamadı", HttpStatusCode.NotFound);
            }
            else
            {
                return _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
            }
        }
    }
}
