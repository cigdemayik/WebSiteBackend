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
                        Key="TestBaslik",
                        Value="English Header",
                        Language=1
                    },
                    new LocalizationResource()
                    {
                        Id=2,
                        Key="TestBaslik",
                        Value="Türkçe Başlık",
                        Language=2
                    },
                }
                );
        }
    }
}
