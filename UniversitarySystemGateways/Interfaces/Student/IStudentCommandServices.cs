using UniversitarySystem.UsesCases.POCOEntities;

namespace UniversitarySystemGateways.Interfaces.Student
{
    public interface IStudentCommandServices
    {
        Task AddStudentAsync(StudentEntity student);
        Task RemoveStudent(int studentId);
        Task SaveStudent();
    }
}
