using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystem.EFCore.Context
{
    public class UniversitarySystemContext(IOptions<DBOption> dbOptions) : DbContext
    {
        //Propiedades que determinan las tablas que se crean en la base de datos.
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<TitleEntity> Titles { get; set; }
        public DbSet<CollegeCareerEntity> CollegeCareers { get; set; }
        public DbSet<PsychophysicalEntity> Psychophysicals { get; set; }
        public DbSet<BloodTypeEntity> BloodTypes { get; set; }
        public DbSet<DetailsEntity> Details { get; set; }
        public DbSet<ProvinceEntity> Provinces { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<AddressEntity> DetailAddress { get; set; }
        public DbSet<TypeCareersEntity> TypeCareers { get; set; }
        public DbSet<Student_CollegeCareerEntity> Students_CollegeCareers { get; set; }
        public DbSet<Psychophysical_DetailsEntity> Psychophysicals_Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Establece la conexión con la base de datos.
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(dbOptions.Value.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Busca dentro del proyecto todas las clases que implementan IEntityTypeConfiguration y aplica
            //todo el código de configuración que contengan.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
