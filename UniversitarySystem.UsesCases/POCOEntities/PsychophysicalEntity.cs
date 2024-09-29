using UniversitarySystem.UsesCases.ValueObjects;

namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class PsychophysicalEntity
    {
        public int IdPsychophysical { get; set; }
        public string AdditionalComments { get; set; }
   

        //Propiedades para establecer relaciones
        public int BloodTypeId { get; set; }////Clave foránea
        public BloodTypeEntity BloodType { get; set; }//Tabla a la que hace referencia
        public int StudentId { get; set; } //Clave foránea
        public StudentEntity Student { get; set; } //Tabla a la que hace referencia


        #region Propiedades para determinar relaciones.
        //Relacion de muchos a muchos a traves de una tabla puente (Psychophysical_Details).
        public ICollection<Psychophysical_DetailsEntity> PsychophysicalsDetails { get; set; } = new List<Psychophysical_DetailsEntity>();
        #endregion
    }
}
