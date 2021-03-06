using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Abstracts.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
       
    }
}
