using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Configurations
{
    public class VisionConfiguration : IEntityTypeConfiguration<Vision>
    {
        public void Configure(EntityTypeBuilder<Vision> builder)
        {
            builder.ToTable("Vision");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Content).IsRequired();

            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.CreateTime).HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Active).HasDefaultValue(1);

            builder.Property(x => x.UpdateTime).IsRequired(false);

            builder.Property(x => x.Language).IsRequired();

            builder.HasData(new List<Vision>()
            {
                new Vision(){
                Id = 1,
                Active = true,
                Content = "Test Türkçe",
                Language = Helpers.Enums.LanguageEnum.Türkçe
           },
                new Vision()
                {
                    Id=2,
                    Active=true,
                    Content = "Test English",
                    Language = Helpers.Enums.LanguageEnum.English
                } });
        }
    }
}
