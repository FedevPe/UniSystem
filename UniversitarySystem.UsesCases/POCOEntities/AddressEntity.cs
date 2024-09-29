namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class AddressEntity
    {
        public int IdAddress { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }

        //Propiedades de relacion entre tablas
        public int CityId { get; set; }
        public CityEntity City { get; set; }

        public int StudentId { get; set; }
        public StudentEntity Student { get; set; }
    }
}
