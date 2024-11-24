
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NhienDentistry.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.Configurations
{
    public class SlideConfiguration : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable("Slides");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Url).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.HasOne(x => x.Image).WithOne(x => x.Slide).HasForeignKey<Image>(x => x.SlideId).IsRequired(false);
        }
    }
}