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
    public class UserManager : GenericManager<User>, IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public UserManager(IUnitOfWork unitOfWork, IGenericRepository<User> generic, IServiceResponseHelper serviceResponseHelper) : base(unitOfWork, generic, serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            _serviceResponseHelper = serviceResponseHelper;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public User GetById(int id)
        {
            return _unitOfWork.Users.GetByFilter(x => x.Id==id);
        }
    }
}
