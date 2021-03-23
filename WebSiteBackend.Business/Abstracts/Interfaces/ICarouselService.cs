using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces.Generic
{
    public interface ICarouselService:IGenericService<Carousel>
    {
        ServiceResponse<Carousel> GetById(int id);
    }
}
