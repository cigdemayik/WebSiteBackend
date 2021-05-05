using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IBlogService:IGenericService<Blog>
    {
        ServiceResponse<Blog> GetById(int id);

        ServiceResponse<Blog> GetByIdAsNoTracking(int id);
    }
}
