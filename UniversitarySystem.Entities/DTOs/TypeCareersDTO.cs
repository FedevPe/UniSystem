namespace UniversitarySystem.Entities.DTOs
{
    public class TypeCareersDTO
    {
        public TypeCareersDTO(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
    }
}
