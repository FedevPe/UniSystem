using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.BridgeTables
{
    internal class Psychophysical_DetailsConfiguration : IEntityTypeConfiguration<Psychophysical_DetailsEntity>
    {
        public void Configure(EntityTypeBuilder<Psychophysical_DetailsEntity> builder)
        {
            builder.ToTable("Details.Psychophysicals");
            builder.HasKey(a => new { a.DetailId , a.PsychophysicalId });
        }
    }
}
