using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.SecondaryTables
{
    internal class DetailsTypeConfiguration : IEntityTypeConfiguration<DetailsTypeEntity>
    {
        public void Configure(EntityTypeBuilder<DetailsTypeEntity> builder)
        {
            builder.HasKey(a => a.IdDetailType);
            builder.Property(a => a.IdDetailType).ValueGeneratedOnAdd();
            builder.Property(a => a.DetailTypeDescription).HasMaxLength(100).IsRequired();
        }
    }
}
