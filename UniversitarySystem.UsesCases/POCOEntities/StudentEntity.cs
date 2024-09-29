using UniversitarySystem.UsesCases.ValueObjects;

namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class StudentEntity
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public string CUIL { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public DateOnly DateRegistry { get; set; }
        public bool State { get; set; }


        #region Propiedades para determinar relaciones entre tablas

        //Un estudiante puede tener muchos Psicofísicos. Relacion de uno a muchos
        public ICollection<PsychophysicalEntity> Psychophysicals { get; set; } = new List<PsychophysicalEntity>();
        
        //Un estudiante puede estar inscripto en muchas carreras. Relación de muchos a muchos a traves de una tabla puente.
        public ICollection<Student_CollegeCareerEntity> StudentCollegeCareers { get; set; } = new List<Student_CollegeCareerEntity>();
        #endregion
    }
}
