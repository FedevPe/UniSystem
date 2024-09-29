using UniversitarySystem.Entities.DTOs;

namespace UniversitarySystem.UsesCases.BusinessObject.Controllers
{
    public interface IStudentController
    {
        Task<int> AddStudent(StudentDTO studentDTO);
    }
}
