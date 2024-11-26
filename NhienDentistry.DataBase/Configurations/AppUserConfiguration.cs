using NhienDentistry.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace NhienDentistry.DataBase.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Dob).IsRequired();
            builder.HasOne(x => x.Avatar).WithMany(x => x.AppUsers).HasForeignKey(x => x.AvatarId).IsRequired(false);
            builder.HasMany(x => x.Categories).WithOne(x => x.AppUser).HasForeignKey(x => x.UserId).IsRequired(false);
        }
    }
}
