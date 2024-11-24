
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NhienDentistry.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.Configurations
{
    public class LoggerConfiguration : IEntityTypeConfiguration<Logger>
    {
        public void Configure(EntityTypeBuilder<Logger> builder)
        {
            builder.ToTable("Loggers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Body).IsRequired();
            builder.Property(x => x.IdAddress).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();

        }
    }
}