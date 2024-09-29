using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student;

namespace UniversitarySystemControllers.Implementations
{
    public class StudentController (
        IStudentInputPort inputPort, 
        IStudentOutputPort presenter) : IStudentController
    {
        public async Task<int> AddStudent(StudentDTO studentDTO)
        {
            await inputPort.Handle(studentDTO);
            return presenter.IdStudent;
        }
    }
}
