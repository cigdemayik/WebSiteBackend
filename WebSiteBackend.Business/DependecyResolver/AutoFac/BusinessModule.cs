using Autofac.Extras.DynamicProxy;
using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Concrete;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Helpers.CrossCutttingConcerns;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;
using WebSiteBackend.Business.Aspect;
using System.Linq;
using WebSiteBackend.Business.Aspect.AspectMarker;
using Serilog;

namespace WebSiteBackend.Business.DependecyResolver.AutoFac
{
    public class BusinessModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Generic Registiration
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            #endregion

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerDependency();

            builder.RegisterType<ServiceResponseHelper>().As<IServiceResponseHelper>().InstancePerLifetimeScope();

            builder.RegisterType<BlogManager>().As<IBlogService>().InstancePerLifetimeScope();
            builder.RegisterType<CarouselManager>().As<ICarouselService>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductManager>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<UserManager>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<AboutUsManager>().As<IAboutUsService>().InstancePerLifetimeScope();
            builder.RegisterType<VisionManager>().As<IVisionService>().InstancePerLifetimeScope();
            builder.RegisterType<MissionManager>().As<IMissionService>().InstancePerLifetimeScope();
            builder.RegisterType<AddressManager>().As<IAddressService>().InstancePerLifetimeScope();
            builder.RegisterType<NewsManager>().As<INewsService>().InstancePerLifetimeScope();

            builder.RegisterType<BusinessAspect>().As<BusinessAspect>().SingleInstance();
            builder.RegisterType<BusinessLogAspect>().As<BusinessLogAspect>().SingleInstance();
            
            builder.Register<ILogger>((c, p) =>
            {
                return new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(path: AppDomain.CurrentDomain.BaseDirectory.ToString(), rollingInterval: RollingInterval.Day)
                .CreateLogger();
            }).SingleInstance();
            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                 .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                 {
                     Selector = new AspectInterceptorSelector()
                 }).SingleInstance();

        }
    }
}
