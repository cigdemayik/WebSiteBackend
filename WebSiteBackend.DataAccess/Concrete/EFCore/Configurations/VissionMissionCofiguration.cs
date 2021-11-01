using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Configurations
{
    public class VissionMissionCofiguration : IEntityTypeConfiguration<VisionMission>
    {
        public void Configure(EntityTypeBuilder<VisionMission> builder)
        {
            builder.ToTable("VissionMission");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Content).IsRequired();

            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.CreateTime).HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Active).HasDefaultValue(1);

            builder.Property(x => x.UpdateTime).IsRequired(false);

            builder.Property(x => x.Language).IsRequired();
        }
    }
}
