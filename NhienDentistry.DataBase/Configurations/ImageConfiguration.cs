using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NhienDentistry.DataBase.Entities;

namespace NhienDentistry.DataBase.Configurations;


public class ImageConfiguration : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.Path).IsRequired();
        builder.HasMany(x => x.Articles).WithMany(x => x.Images);
        builder.Property(x => x.CreatedDate).IsRequired();
    }
}
