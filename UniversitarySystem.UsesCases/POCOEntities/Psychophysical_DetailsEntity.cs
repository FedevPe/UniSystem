namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class Psychophysical_DetailsEntity
    {
        //Propiedades para establecer relaciones entre tablas
        public int PsychophysicalId { get; set; } //Clave foránea y principal
        public PsychophysicalEntity Psychophysical { get; set; }
        public int DetailId { get; set; }//Clave foránea y principal
        public DetailsEntity Detail { get; set; }

    }
}
