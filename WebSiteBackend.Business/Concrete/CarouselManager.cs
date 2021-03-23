using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Business.Concrete.Generic;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class CarouselManager : GenericManager<Carousel>, ICarouselService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public CarouselManager(
            IUnitOfWork unitOfWork,
            IGenericRepository<Carousel> generic,
            IServiceResponseHelper serviceResponseHelper
            )
            : base(unitOfWork, generic,serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public ServiceResponse<Carousel> GetById(int id)
        {
            var data = _unitOfWork.Carousels.GetByFilter(x => x.Id == id);
            if (data == null)
            {
                return _serviceResponseHelper.SetError<Carousel>(data, "Carousel Bulunamadı", HttpStatusCode.NotFound);
            }
            else
            {
                return _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
            }
        }
    }
}
