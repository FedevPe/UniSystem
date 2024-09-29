namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class CityEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region Propiedades de relación
        public int ProvinceId { get; set; }
        public ProvinceEntity Province { get; set; }
        #endregion
    }
}
