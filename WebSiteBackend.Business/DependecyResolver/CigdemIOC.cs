using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Concrete;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.DependecyResolver
{
    public static class CigdemIOC
    {

        public static void AddDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<WebSiteContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("CigdemTest"));
            }, ServiceLifetime.Transient);

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            services.AddScoped<IUnitOfWork, UnitOfWork>();


            services.AddScoped<IBlogService, BlogManager>();

            services.AddScoped<ICarouselService, CarouselManager>();

            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<IAboutUsService, AboutUsManager>();

            services.AddScoped<IServiceResponseHelper, ServiceResponseHelper>();

            services.AddScoped<IAboutUsService, AboutUsManager>();

            services.AddScoped<IVissionMissionService, VissionMissionManager>();
        }
    }
}
