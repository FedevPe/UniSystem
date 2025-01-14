namespace UniversitarySystem.Entities.DTOs
{
    public class TitleDTO
    {
        public TitleDTO(int id, int studentId, 
            string highSchool, string secondaryDegree,
            DateOnly egressDate)
        {
            Id = id;
            StudentId = studentId;
            HighSchool = highSchool;
            SecondaryDegree = secondaryDegree;
            EgressDate = egressDate;
        }
        public int Id { get; }
        public int StudentId { get; }
        public string SecondaryDegree { get; }
        public string HighSchool { get; }
        public DateOnly EgressDate { get; }
    }
}