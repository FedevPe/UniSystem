namespace UniversitarySystem.Entities.DTOs
{
    public class CityDTO
    {
        public CityDTO(int id, string name, int provinceId)
        {
            Id = id;
            Name = name;
            ProvinceId = provinceId;
        }
        public int Id { get; }
        public string Name { get; }
        public int ProvinceId { get; }
    }
}
