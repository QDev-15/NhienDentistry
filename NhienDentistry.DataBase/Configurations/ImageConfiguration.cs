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
        builder.Property(x => x.Status).IsRequired();
        builder.HasOne(x => x.News).WithMany(x => x.Images).HasForeignKey(x => x.Id);
        builder.Property(x => x.CreatedDate).IsRequired();
    }
}
