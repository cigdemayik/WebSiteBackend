using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blog");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CategoryId).IsRequired();

            builder.Property(x => x.Content).IsRequired();

            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.CreateTime).HasDefaultValueSql("GetDate()");

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Active).HasDefaultValue(1);

            builder.Property(x => x.Header).IsRequired();
            builder.Property(x => x.Header).HasMaxLength(256);

            builder.Property(x => x.ImageUrl).IsRequired(false);
            builder.Property(x => x.ImageUrl).HasMaxLength(512);

            builder.Property(x => x.UpdateTime).IsRequired(false);

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.Language).IsRequired();


            builder.HasOne(x => x.Category)
                .WithMany(x => x.Blogs)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Blogs)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new List<Blog>()
            {
                new Blog()
                {
                    Id=1,
                    CategoryId=1,
                    Content="",
                    ImageUrl="a",
                    Header="Test Blog1",
                    UserId=1,
                    Language=1
                },
                new Blog()
                {
                    Id=2,
                    CategoryId=1,
                    Content="",
                    ImageUrl="a",
                    Header="Test Blog2",
                    UserId=1,
                    Language=1
                },
                new Blog()
                {
                    Id=3,
                    CategoryId=1,
                    Content="",
                    ImageUrl="a",
                    Header="Test Blog3",
                    UserId=1,
                    Language=1
                },
                new Blog()
                {
                    Id=4,
                    CategoryId=1,
                    Content="",
                    ImageUrl="a",
                    Header="Test Blog4",
                    UserId=1,
                    Language=1 
                },
                    new Blog()
                {
                    Id=5,
                    CategoryId=1,
                    Content="",
                    ImageUrl="a",
                    Header="Test Blog5",
                    UserId=1,
                    Language=1 
                    },

                    new Blog()
                {
                    Id=6,
                    CategoryId=1,
                    Content="",
                    ImageUrl="a",
                    Header="Test Blog6",
                    UserId=1,
                    Language=1
                }
            });
        }
    }
}
