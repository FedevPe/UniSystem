using System.Net;
using System.Reflection.Emit;
using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystem.UsesCases.ValueObjects;

namespace UniversitarySystem.UsesCases.Aggregates
{
    public class CreateStudentAggregate : StudentEntity
    {
        public TitleVO TittleStudent { get; private set; }
        public AddressVO AddressStudent { get; private set; }

        public void AddTitle(int idStudent, string secondaryDegree, string hihgSchool, DateOnly egressDate)
        {
            TittleStudent = new TitleVO(idStudent, secondaryDegree, hihgSchool, egressDate);
        }
        public void AddAddress(int idStudent, string address, string zipCode, int idCity)
        {
            AddressStudent = new AddressVO(idStudent, address, zipCode, idCity);
        }
        public static CreateStudentAggregate DtoToAgreggate(StudentDTO createStudentDTO)
        {
            CreateStudentAggregate studentAggregate = new CreateStudentAggregate()
            {
                FirstName = createStudentDTO.FirstName,
                LastName = createStudentDTO.LastName,
                DNI = createStudentDTO.DNI,
                CUIL = createStudentDTO.CUIL,
                DateOfBirth = createStudentDTO.DateOfBirth,
                NumberPhone = createStudentDTO.NumberPhone,
                Email = createStudentDTO.Email,
                DateRegistry = createStudentDTO.DateRegistry,
            };

            if (createStudentDTO.TittleStudent != null)
            {
                studentAggregate.AddTitle(
                    createStudentDTO.TittleStudent.StudentId,
                    createStudentDTO.TittleStudent.SecondaryDegree,
                    createStudentDTO.TittleStudent.HighSchool,
                    createStudentDTO.TittleStudent.EgressDate);
            }
            if (createStudentDTO.AddressStudent != null)
            {
                studentAggregate.AddAddress(
                    createStudentDTO.AddressStudent.StudentId,
                    createStudentDTO.AddressStudent.Address,
                    createStudentDTO.AddressStudent.ZipCode,
                    createStudentDTO.AddressStudent.CityId
                    );
            }
            return studentAggregate;
        }
    }
}
