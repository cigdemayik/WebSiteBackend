using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IBlogService:IGenericService<Blog>
    {
        Blog GetById(int id);
    }
}
