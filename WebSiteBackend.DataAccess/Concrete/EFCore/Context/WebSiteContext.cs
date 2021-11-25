using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.DataAccess.Concrete.EFCore.Configurations;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Context
{
    public class WebSiteContext : DbContext
    {
        public WebSiteContext(DbContextOptions<WebSiteContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new CarouselConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfigutaion());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AboutUsConfiguration());
            modelBuilder.ApplyConfiguration(new VisionConfiguration());
            modelBuilder.ApplyConfiguration(new MissionConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            modelBuilder.ApplyConfiguration(new ExceptionLogConfiguration());
            modelBuilder.ApplyConfiguration(new LocalizationResourceConfiguration());
        }


        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Carousel> Carousels { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Vision> Visions { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
    }
}
