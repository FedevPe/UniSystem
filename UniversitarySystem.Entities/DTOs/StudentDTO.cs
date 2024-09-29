namespace UniversitarySystem.Entities.DTOs
{
    public class StudentDTO
    {
        public StudentDTO(int id, string firstName, string lastName, string dni,
            string cuil, DateOnly dateOfBirth, string numberPhone,
            string email, DateOnly dateRegistry,
            TitleDTO tittleStudent, AddressDTO address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DNI = dni;
            CUIL = cuil;
            DateOfBirth = dateOfBirth;
            NumberPhone = numberPhone;
            Email = email;
            DateRegistry = dateRegistry;
            TittleStudent = tittleStudent;
            AddressStudent = address;
        }
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string DNI { get; }
        public string CUIL { get; }
        public DateOnly DateOfBirth { get; }
        public string NumberPhone { get; }
        public string Email { get; }
        public DateOnly DateRegistry { get; }
        public TitleDTO TittleStudent { get; }
        public AddressDTO AddressStudent { get; }
    }
}
