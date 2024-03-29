﻿using Castle.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Aspect;
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
        public static void AddProxiedScoped<TInterface, TImplementation>(this IServiceCollection services)
          where TInterface : class
          where TImplementation : class, TInterface
        {
            services.AddScoped<TImplementation>();
            services.AddScoped(typeof(TInterface), serviceProvider =>
            {
                var proxyGenerator = serviceProvider.GetRequiredService<ProxyGenerator>();
                var actual = serviceProvider.GetRequiredService<TImplementation>();
                var interceptors = serviceProvider.GetServices<IInterceptor>().ToArray();
                return proxyGenerator.CreateInterfaceProxyWithTarget(typeof(TInterface), actual, interceptors);
            });
        }
        public static void AddDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<WebSiteContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("AlpTest"));
            }, ServiceLifetime.Transient);

            //services.AddSingleton(new ProxyGenerator());

            //services.AddScoped<IInterceptor, BusinessAspect>();

            //services.AddProxiedScoped<ICarouselService, CarouselManager>();

            //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped<IBlogService, BlogManager>();

            //services.AddScoped<ICarouselService, CarouselManager>();

            //services.AddScoped<ICategoryService, CategoryManager>();

            //services.AddScoped<IProductService, ProductManager>();

            //services.AddScoped<IUserService, UserManager>();

            //services.AddScoped<IAboutUsService, AboutUsManager>();

            //services.AddScoped<IServiceResponseHelper, ServiceResponseHelper>();

            //services.AddScoped<IVisionService, VisionManager>();

            //services.AddScoped<IMissionService, MissionManager>();

            //services.AddScoped<IAddressService, AddressManager>();

            //services.AddScoped<INewsService, NewsManager>();
        }
    }
}
