using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Configurations
{
    public class CarouselConfiguration : IEntityTypeConfiguration<Carousel>
    {
        public void Configure(EntityTypeBuilder<Carousel> builder)
        {
            builder.ToTable("Carousel");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.ImageUrl).HasMaxLength(512);

            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.CreateTime).HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Detail).IsRequired();

            builder.Property(x => x.UpdateTime).IsRequired(false);

            builder.Property(x => x.PublishStartDate).IsRequired();

            builder.Property(x => x.PublishEndDate).IsRequired();

            builder.Property(x => x.Language).IsRequired();

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Active).HasDefaultValue(0);
        }
    }
}
