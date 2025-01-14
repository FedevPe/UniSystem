using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Controllers
{
    public interface IStudentController
    {
        Task<bool> AddStudent(StudentDTO studentDTO);
    }
}
