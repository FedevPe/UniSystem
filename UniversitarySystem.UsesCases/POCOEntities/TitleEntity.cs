namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class TitleEntity
    {
        public int IdTittle { get; set; }
        public string SecondaryDegree { get; set; }
        public string HighSchool { get; set; }
        public DateOnly EgressDate { get; set; }


        #region Propiedades para establecer relaciones entre tablas
        public int StudentId { get; set; } //Clave foránea
        public StudentEntity Student { get; set; } //Tabla a la que hace referencia
        #endregion
    }
}
