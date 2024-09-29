namespace UniversitarySystem.UsesCases.ValueObjects
{
    public class PsychophysicalVO
    {
        public PsychophysicalVO(int idStudent, int idBloodType, string additionalComments)
        {
            IdStudent = idStudent;
            IdBloodType = idBloodType;
            AdditionalComments = additionalComments;
        }
        public int IdStudent { get; }
        public int IdBloodType { get; }
        public string AdditionalComments { get; }
    }
}
