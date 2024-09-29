using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.Aggregates;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student;
using UniversitarySystem.UsesCases.BusinessObject.Repository;

namespace UniversitarySystem.UsesCases.Interactors
{
    public class StudentInteractor(
        IStudentOutputPort outputPort,
        IStudentRepository repository) : IStudentInputPort
    {
        //Tarea
        public async Task Handle(StudentDTO createStudentDTO)
        {
            CreateStudentAggregate createStudent = CreateStudentAggregate.DtoToAgreggate(createStudentDTO);

            await repository.AddStudent(createStudent);
            await repository.SaveChanges();
            await outputPort.Handle(createStudent);
        }

    }
}
