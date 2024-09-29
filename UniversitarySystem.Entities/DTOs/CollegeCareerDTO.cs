namespace UniversitarySystem.Entities.DTOs
{
    public class CollegeCareerDTO
    {
        public CollegeCareerDTO(int id, string name, string description, int duration, int typeId)
        {
            Id = id;
            Name = name;
            Description = description;
            Duration = duration;
            TypeId = typeId;
        }
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Duration { get; }
        public int TypeId { get; }
    }
}
