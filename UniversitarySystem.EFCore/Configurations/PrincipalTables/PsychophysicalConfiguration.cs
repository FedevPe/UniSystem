using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.PrincipalTables
{
    internal class PsychophysicalConfiguration : IEntityTypeConfiguration<PsychophysicalEntity>
    {
        public void Configure(EntityTypeBuilder<PsychophysicalEntity> builder)
        {
            builder.HasKey(a => a.IdPsychophysical);
            builder.Property(a => a.IdPsychophysical).ValueGeneratedOnAdd();
            builder.Property(a => a.StudentId).IsRequired();
            builder.Property(a => a.BloodTypeId).IsRequired();
            builder.Property(a => a.AdditionalComments).HasMaxLength(500).IsRequired(false);
        }
    }
}
