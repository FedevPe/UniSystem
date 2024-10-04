using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.SecondaryTables
{
    public class CollegeCareerConfiguration : IEntityTypeConfiguration<CollegeCareerEntity>
    {
        public void Configure(EntityTypeBuilder<CollegeCareerEntity> builder)
        {
            builder.HasKey(a => a.IdCollegeCareer);
            builder.Property(a => a.IdCollegeCareer).ValueGeneratedOnAdd();
            builder.Property(a => a.CollegeCareer).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(500).IsRequired();
            builder.Property(a => a.TypeCareersId).IsRequired();            
        }
    }
}
