using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.SecondaryTables
{
    internal class BloodTypeConfiguration : IEntityTypeConfiguration<BloodTypeEntity>
    {
        public void Configure(EntityTypeBuilder<BloodTypeEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.BloodType).HasMaxLength(6).IsRequired();
        }
    }
}
