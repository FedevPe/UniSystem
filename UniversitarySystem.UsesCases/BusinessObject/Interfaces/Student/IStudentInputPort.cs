using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student
{
    public interface IStudentInputPort
    {
        Task Handle(StudentDTO createStudentDTO);
    }
}
