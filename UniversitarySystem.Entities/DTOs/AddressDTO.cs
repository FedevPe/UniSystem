namespace UniversitarySystem.Entities.DTOs
{
    public class AddressDTO
    {
        public AddressDTO(int id, int idStudent, string address, string zipCode, int idCity, int provinceId)
        {
            Id = id;
            StudentId = idStudent;
            Address = address;
            ZipCode = zipCode;
            CityId = idCity;
            ProvinceId = provinceId;
        }
        public int Id { get; }
        public int StudentId { get; }
        public string Address { get; }
        public string ZipCode { get; }
        public int CityId { get; }
        public int ProvinceId { get; set; }
    }
}
