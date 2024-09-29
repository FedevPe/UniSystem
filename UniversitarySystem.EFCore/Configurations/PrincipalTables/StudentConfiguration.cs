using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Configurations.PrincipalTables
{
    //Clase para configurar las tablas de la base de datos.
    internal class StudentConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.HasKey(a => a.IdStudent);
            builder.Property(a => a.IdStudent).ValueGeneratedOnAdd();
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.DNI).HasMaxLength(8).IsRequired();
            builder.Property(a => a.CUIL).HasMaxLength(11).IsRequired();
            builder.Property(a => a.DateOfBirth).IsRequired();
            builder.Property(a => a.NumberPhone).HasMaxLength(20).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(100).IsRequired(false);
            builder.Property(a => a.DateRegistry).IsRequired();
            builder.Property(a => a.State).IsRequired().HasDefaultValue(true);
        }
    }
}
