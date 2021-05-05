    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSiteBackend.DataAccess.Abstracts.Interfaces;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic
{
    public interface IUnitOfWork:IDisposable//IUnitOfWork ün işlemi bitince otomatik olarak silinsin.
    {
        IUserRepository Users { get; }
        IBlogRepository Blogs { get; }
        ICarouselRepository Carousels { get; }
        IProductRepository Products { get; }
        ICategoryRepository Categories { get;}


        //TEntity Create<TEntity>(TEntity entity) where TEntity : class, ITable, new();
        //void Delete(int id);
        //List<ITable> GetWithFilter();
        //void Update<TEntity>(TEntity entity) where TEntity : class, ITable, new();

        void SaveChanges();//Bütün crud işlemleri bittikten sonra kaydetsin. UOW kanunları
        Task SaveChangesAsync();

        int complete();
    }
}