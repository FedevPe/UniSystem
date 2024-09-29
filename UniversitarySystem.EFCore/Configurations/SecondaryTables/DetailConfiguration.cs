using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.SecondaryTables
{
    internal class DetailConfiguration : IEntityTypeConfiguration<DetailsEntity>
    {
        public void Configure(EntityTypeBuilder<DetailsEntity> builder)
        {
            builder.HasKey(a => a.IdDetail);
            builder.Property(a => a.IdDetail).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).HasMaxLength(150).IsRequired();
        }
    }
}
