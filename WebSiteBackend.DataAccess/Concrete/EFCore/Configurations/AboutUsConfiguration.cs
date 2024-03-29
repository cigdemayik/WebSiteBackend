﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Configurations
{
    public class AboutUsConfiguration : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            builder.ToTable("AboutUs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Content).IsRequired();

            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.CreateTime).HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Active).HasDefaultValue(1);

            builder.Property(x => x.UpdateTime).IsRequired(false);

            builder.Property(x => x.Language).IsRequired();

            builder.Property(x => x.ImageUrl).IsRequired();

            builder.Property(x => x.Link).IsRequired();

            builder.HasData(new List<AboutUs>()
            { 
                new AboutUs()
                {
                    Id=1,
                    Active=true,
                    Content = "Test Türkçe",
                    Language = 1,
                    Link="https://www.youtube.com/watch?v=TfiWIxFgIpI",
                    ImageUrl="a"
                },
                new AboutUs()
                {
                    Id=2,
                    Active=true,
                    Content = "Test English",
                    Language = 2,
                    Link="https://www.youtube.com/watch?v=TfiWIxFgIpI",
                    ImageUrl="a"
                }
            });
        }
    }
}
