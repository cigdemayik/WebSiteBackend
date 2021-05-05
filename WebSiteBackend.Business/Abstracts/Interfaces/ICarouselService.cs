using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface ICarouselService:IGenericService<Carousel>
    {
        ServiceResponse<Carousel> GetById(int id);
        ServiceResponse<Carousel> GetByIdAsNoTracking(int id);
    }
}
