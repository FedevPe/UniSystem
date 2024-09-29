namespace UniversitarySystem.UsesCases.ValueObjects
{
    public class AddressVO
    {
        public AddressVO(int idStudent, string address, string zipCode, int idCity)
        {
            StudentId = idStudent;
            Address = address;
            ZipCode = zipCode;
            IdCity = idCity;
        }
        public int StudentId { get; }
        public string Address { get; }
        public string ZipCode { get; }
        public int IdCity { get; }
    }
}
