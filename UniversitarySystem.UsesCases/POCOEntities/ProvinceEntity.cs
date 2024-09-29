namespace UniversitarySystem.UsesCases.POCOEntities
{
    public class ProvinceEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CityEntity> City { get; set; } = new List<CityEntity>();
    }
}
