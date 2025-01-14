namespace UniversitarySystem.Entities.DTOs
{
    public class CollegeCareerDTO
    {
        public CollegeCareerDTO(int id, string name, string description, 
            string duration, int typeId, string mode, bool status, TypeCareersDTO typeCareers)
        {
            Id = id;
            Name = name;
            Description = description;
            Duration = duration;
            TypeId = typeId;
            Mode = mode;
            Status = status;
            TypeCareers = typeCareers;
        }
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Duration { get; }
        public int TypeId { get; }
        public TypeCareersDTO TypeCareers { get; }
        public string Mode { get; }
        public bool Status { get; }
    }
}
