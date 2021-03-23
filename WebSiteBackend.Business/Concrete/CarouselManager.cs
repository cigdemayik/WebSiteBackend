using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Business.Concrete.Generic;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;

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

        public Carousel GetById(int id)
        {
            return _unitOfWork.Carousels.GetByFilter(x => x.Id == id);
        }
    }
}
