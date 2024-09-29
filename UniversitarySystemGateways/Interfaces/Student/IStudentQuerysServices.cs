using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.Student
{
    public interface IStudentQueryServices
    {
        Task<StudentEntity> GetStudentById(int studentId);
        Task<IEnumerable<StudentEntity>> GetAllStudents();
    }
}
