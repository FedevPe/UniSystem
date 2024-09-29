namespace UniversitarySystem.UsesCases.ValueObjects
{
    public class BloodTypeVO
    {
        public BloodTypeVO(int idBloodType, string bloodType)
        {
            IdBloodType = idBloodType;
            BloodType = bloodType;
        }

        public int IdBloodType { get;}
        public string BloodType { get;}
    }
}
