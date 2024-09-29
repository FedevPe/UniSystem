namespace UniversitarySystem.Entities.DTOs
{
    public class AddressDTO
    {
        public AddressDTO(int id, int idStudent, string address, string zipCode, int idCity)
        {
            Id = id;
            StudentId = idStudent;
            Address = address;
            ZipCode = zipCode;
            IdCity = idCity;
        }
        public int Id { get; }
        public int StudentId { get; }
        public string Address { get; }
        public string ZipCode { get; }
        public int IdCity { get; }
    }
}
