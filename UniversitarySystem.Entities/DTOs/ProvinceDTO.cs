namespace UniversitarySystem.Entities.DTOs
{
    public class ProvinceDTO
    {
        public ProvinceDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; }
        public string Name { get; }
    }
}
