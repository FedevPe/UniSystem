using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.Student;

namespace UniversitarySystem.EFCore.Services.Students
{
    public class StudentQuerysServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), IStudentQueryServices
    {
        public async Task<IEnumerable<StudentEntity>> GetAllStudents()
        {
            return await Students.ToListAsync();
        }
        public async Task<StudentEntity> GetStudentById(int studentId)
        {
            return await Students.FindAsync(studentId);
        }
    }
}
