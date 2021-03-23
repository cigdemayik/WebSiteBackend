using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Business.Concrete;
using WebSiteBackend.Business.Concrete.Generic;
using WebSiteBackend.DataAccess.Abstracts.Interfaces;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.DependecyResolver
{
    public static class CigdemIOC
    {

        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IBlogService, BlogManager>();
            //services.AddScoped<IBlogRepository, BlogRepository>();

            services.AddScoped<ICarouselService, CarouselManager>();
            //services.AddScoped<ICarouselRepository, CarouselRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            //services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IProductService, ProductManager>();
            //services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IUserService, UserManager>();
            //services.AddScoped<IUserRepository, UserRepository>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IServiceResponseHelper, ServiceResponseHelper>();
        }
    }
}
