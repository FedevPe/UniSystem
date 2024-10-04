using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.SecondaryTables
{
    public class TypeCareersConfig : IEntityTypeConfiguration<TypeCareersEntity>
    {
        public void Configure(EntityTypeBuilder<TypeCareersEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Type).HasMaxLength(50).IsRequired();
        }
    }
}
