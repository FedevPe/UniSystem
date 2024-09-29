using System.Collections.Generic;

namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class Student_CollegeCareerEntity
    {
        //Propiedades para establecer realaciones entre tablas
        public int StudentId { get; set; } //Clave foránea y principal
        public StudentEntity Student { get; set; }
        public int CollegeCareerId { get; set; } //Clave foránea y principal
        public CollegeCareerEntity CollegeCareer { get; set; }
    }
}
