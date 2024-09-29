using UniversitarySystem.UsesCases.Aggregates;
using UniversitarySystem.UsesCases.BusinessObject.Repository;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.AddressInformation;
using UniversitarySystemGateways.Interfaces.Student;
using UniversitarySystemGateways.Interfaces.TitleInformation;

namespace UniversitarySystemGateways.Implementations
{
    public class StudentRepository(IStudentCommandServices studentCommand,
        ITitleInformationCommandServices titleCommand,
        IAddressInformationCommandServices addressCommand) : IStudentRepository
    {
        public async Task AddStudent(CreateStudentAggregate studentRegistry)
        {
            await studentCommand.AddStudentAsync(studentRegistry);
            await titleCommand.AddTitleInformation(new TitleEntity
            {
                StudentId = studentRegistry.IdStudent,
                SecondaryDegree = studentRegistry.TittleStudent.SecondaryDegree,
                HighSchool = studentRegistry.TittleStudent.HighSchool,
                EgressDate = studentRegistry.TittleStudent.EgressDate
            });
            await addressCommand.AddAddresInformationAsyn(new AddressEntity
            {
                StudentId = studentRegistry.IdStudent,
                Address = studentRegistry.AddressStudent.Address,
                ZipCode = studentRegistry.AddressStudent.ZipCode,
                CityId = studentRegistry.AddressStudent.IdCity
            });
        }
        public async Task SaveChanges()
        {
            await studentCommand.SaveStudent();
        }
    }
}
