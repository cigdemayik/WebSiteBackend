    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.DataAccess.Abstracts.Interfaces;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;
        void SaveChanges();
        Task SaveChangesAsync();
    }
}