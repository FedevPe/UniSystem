using Microsoft.AspNetCore.Mvc;
using UniversitarySystem.Entities.DTOs;
using UniversitarySystem.UsesCases.BusinessObject.Controllers;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student;

namespace UniversitarySystemControllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController (
        IStudentInputPort inputPort, 
        IStudentOutputPort presenter) : IStudentController
    {
        [HttpPost]
        public async Task<bool> AddStudent(StudentDTO studentDTO)
        {
            await inputPort.Handle(studentDTO);
            return presenter.IsSaved;
        }
    }
}
