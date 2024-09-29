using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.BridgeTables
{
    internal class Student_CollegeCareerConfiguration : IEntityTypeConfiguration<Student_CollegeCareerEntity>
    {
        public void Configure(EntityTypeBuilder<Student_CollegeCareerEntity> builder)
        {
            builder.ToTable("CollegeCareers.Students");
            builder.HasKey(x => new { x.StudentId, x.CollegeCareerId });
        }
    }
}
