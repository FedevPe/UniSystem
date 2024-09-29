namespace UniversitarySystem.UsesCases.ValueObjects
{
    public class TitleVO
    {
        public TitleVO(int idStudent, string secondaryDegree, string highSchool, DateOnly egressDate)
        {
            IdStudent = idStudent;
            SecondaryDegree = secondaryDegree;
            HighSchool = highSchool;
            EgressDate = egressDate;
        }
        public int IdStudent { get; }
        public string SecondaryDegree { get; }
        public string HighSchool { get; }
        public DateOnly EgressDate { get; }
    }
}
