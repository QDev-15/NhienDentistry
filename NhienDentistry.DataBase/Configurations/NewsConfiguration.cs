using NhienDentistry.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("Newss");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.showHome).IsRequired();
            builder.HasMany(x => x.Images).WithMany(x => x.News).UsingEntity<Dictionary<string, object>>(
                "NewsImage",
            j => j
                .HasOne<Image>()
                .WithMany()
                .HasForeignKey("ImagesId")
                .OnDelete(DeleteBehavior.Cascade), // Allow cascade delete for images
            j => j
                .HasOne<News>()
                .WithMany()
                .HasForeignKey("NewsId")
                .OnDelete(DeleteBehavior.Restrict));

        }
    }
}
