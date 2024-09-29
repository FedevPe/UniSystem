namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class DetailsEntity
    {
        public int IdDetail { get; set; }
        public string Name { get; set; }


        #region//Propiedades para establecer relaciones
        public int DetailTypeÍd { get; set; } //Clave foránea
        public DetailsTypeEntity DetailType { get; set; }//Tabla a la que hace referencia

        //Relación de muchos a muchos a traves de una tabla puente (Psychophysical_Details)
        public ICollection<Psychophysical_DetailsEntity> PsychophysicalsDetails { get; set; } = new List<Psychophysical_DetailsEntity>();
        #endregion
    }
}
