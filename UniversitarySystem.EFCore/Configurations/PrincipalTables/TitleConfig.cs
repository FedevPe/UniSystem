using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.PrincipalTables
{
    internal class TitleConfig : IEntityTypeConfiguration<TitleEntity>
    {
        public void Configure(EntityTypeBuilder<TitleEntity> builder)
        {
            builder.ToTable("Title");
            builder.HasKey(a => a.IdTittle);
            builder.Property(a => a.StudentId).IsRequired();
            builder.Property(a => a.SecondaryDegree).HasMaxLength(100).IsRequired();
            builder.Property(a => a.HighSchool).HasMaxLength(100).IsRequired();
            builder.Property(a => a.EgressDate).IsRequired();
        }
    }
}
