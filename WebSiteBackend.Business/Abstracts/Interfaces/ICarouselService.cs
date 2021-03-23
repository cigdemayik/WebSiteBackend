using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces.Generic
{
    public interface ICarouselService:IGenericService<Carousel>
    {
        Carousel GetById(int id);
    }
}
