using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.DataAccess.Abstracts.Interfaces;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebSiteContext context;

        private UserRepository _userRepository;

        private BlogRepository _blogRepository;

        private ProductRepository _productRepository;

        private CarouselRepository _carouselRepository;

        private CategoryRepository _categoryRepository;

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(context);
        public IBlogRepository Blogs => _blogRepository = _blogRepository ?? new BlogRepository(context);
        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(context);
        public ICarouselRepository Carousels => _carouselRepository = _carouselRepository ?? new CarouselRepository(context);
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(context);


        public UnitOfWork(WebSiteContext context)
        {
            this.context = context;
        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }

        public int complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
