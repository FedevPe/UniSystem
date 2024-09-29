using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.SecondaryTables
{
    internal class DetailAddressConfig : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.ToTable("DetailAddress");
            builder.HasKey(x => x.IdAddress);
            builder.Property(x => x.IdAddress).ValueGeneratedOnAdd();
            builder.Property(x => x.Address).HasMaxLength(150).IsRequired();
            builder.Property(x => x.ZipCode).HasMaxLength(10).IsRequired();
            builder.Property(x => x.CityId).IsRequired();
        }
    }
}
