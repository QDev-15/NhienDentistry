﻿using NhienDentistry.DataBase.Entities;
using NhienDentistry.Date.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.ParentId).HasDefaultValue(null);
            builder.HasOne(x => x.Parent).WithMany(x => x.Categories).HasForeignKey(x => x.ParentId);
            builder.Property(x => x.CreatedDate).IsRequired();
        }
    }
}