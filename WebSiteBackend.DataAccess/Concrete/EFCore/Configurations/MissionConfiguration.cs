using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Configurations
{
    public class MissionConfiguration : IEntityTypeConfiguration<Mission>
    {
        public void Configure(EntityTypeBuilder<Mission> builder)
        {
            builder.ToTable("Mission");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Content).IsRequired();

            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.CreateTime).HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Active).HasDefaultValue(1);

            builder.Property(x => x.UpdateTime).IsRequired(false);

            builder.Property(x => x.Language).IsRequired();

            builder.HasData(new List<Mission>()
            {
                new Mission(){
                Id = 1,
                Active = true,
                Content = "Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem. tr",
                Language = 1
           },
                new Mission()
                {
                    Id=2,
                    Active=true,
                    Content = "Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem. en",
                    Language = 2
                } });
        }
    }
}
