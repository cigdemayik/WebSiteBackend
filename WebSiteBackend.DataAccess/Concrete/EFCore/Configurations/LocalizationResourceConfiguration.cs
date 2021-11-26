using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Configurations
{
    public class LocalizationResourceConfiguration : IEntityTypeConfiguration<LocalizationResource>
    {
        public void Configure(EntityTypeBuilder<LocalizationResource> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Key).IsRequired();

            builder.Property(x => x.Value).IsRequired();

            builder.Property(x => x.Language).IsRequired();

            builder.Property(x => x.Active).HasDefaultValueSql("1");

            builder.Property(x => x.CreateTime).HasDefaultValueSql("getdate()");


            builder.HasData
                (
                new List<LocalizationResource>()
                {
                    new LocalizationResource()
                    {
                        Id=1,
                        Key="VisionMission",
                        Value="Vision & Mission",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=2,
                        Key="VisionMission",
                        Value="Vizyon & Misyon",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=3,
                        Key="Vision",
                        Value="Vision",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=4,
                        Key="Vision",
                        Value="Vizyon",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=5,
                        Key="Mission",
                        Value="Mission",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=6,
                        Key="Mission",
                        Value="Misyon",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=7,
                        Key="Blogs",
                        Value="Blogs",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=8,
                        Key="Blogs",
                        Value="Bloglar",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=9,
                        Key="AboutUs",
                        Value="About Us",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=10,
                        Key="AboutUs",
                        Value="Hakkımızda",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=11,
                        Key="Contact",
                        Value="Contact",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=12,
                        Key="Contact",
                        Value="İletişim",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=13,
                        Key="ContactUs",
                        Value="ContactUs",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=14,
                        Key="ContactUs",
                        Value="İletişime Geçin",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=15,
                        Key="Address",
                        Value="Address",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=16,
                        Key="Address",
                        Value="Adres",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=17,
                        Key="Phone",
                        Value="Phone",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=18,
                        Key="Phone",
                        Value="Telefon",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=19,
                        Key="EMail",
                        Value="E-Mail",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=20,
                        Key="EMail",
                        Value="E-Posta",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=21,
                        Key="Follow",
                        Value="Follow Us",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=22,
                        Key="Follow",
                        Value="Takip Et",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=23,
                        Key="LastBlog",
                        Value="Last Blog",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=24,
                        Key="LastBlog",
                        Value="Son Yayınlanan Blog",
                        Language=2

                    },
                    new LocalizationResource()
                    {
                        Id=25,
                        Key="LastBlogs",
                        Value="Last Blogs",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=26,
                        Key="LastBlogs",
                        Value="Son Yayınlanann Bloglar",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=27,
                        Key="More",
                        Value="Show More",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=28,
                        Key="More",
                        Value="Daha Fazla...",
                        Language=2
                    },
                    new LocalizationResource()
                    {
                        Id=29,
                        Key="Home",
                        Value="Home",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=30,
                        Key="Home",
                        Value="Anasayfa",
                        Language=2

                    },
                    new LocalizationResource()
                    {
                        Id=31,
                        Key="Blog",
                        Value="Blog",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=32,
                        Key="Blog",
                        Value="Blog",
                        Language=2

                    },
                    new LocalizationResource()
                    {
                        Id=33,
                        Key="Admin",
                        Value="Admin",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=34,
                        Key="Admin",
                        Value="Admin",
                        Language=2

                    },new LocalizationResource()
                    {
                        Id=35,
                        Key="AllRights",
                        Value="All Rights By",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=36,
                        Key="AllRights",
                        Value="Tüm Hakları",
                        Language=2

                    },
                    
                    new LocalizationResource()
                    {
                        Id=37,
                        Key="Reserved",
                        Value="Reserved",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=38,
                        Key="Reserved",
                        Value="Tarafından Saklıdır.",
                        Language=2

                    },
                    new LocalizationResource()
                    {
                        Id=39,
                        Key="PageNotFound",
                        Value="Page Not Found",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=40,
                        Key="PageNotFound",
                        Value="Sayfa Bulunmadı",
                        Language=2

                    },
                }
                );
        }
    }
}
