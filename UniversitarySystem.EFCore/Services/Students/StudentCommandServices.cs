using Microsoft.Extensions.Options;
using UniversitarySystem.EFCore.Context;
using UniversitarySystem.EFCore.Options;
using UniversitarySystem.UsesCases.POCOEntities;
using UniversitarySystemGateways.Interfaces.Student;

namespace UniversitarySystem.EFCore.Services.Students
{
    public class StudentCommandServices(IOptions<DBOption> options) :
        UniversitarySystemContext(options), IStudentCommandServices
    {
        public async Task AddAddressStudentAsync(AddressEntity address)
        {
            await AddAsync(address);

            await SaveChangesAsync();
        }

        public async Task AddStudentAsync(StudentEntity student)
        {
            await AddAsync(student);

            await SaveChangesAsync();
        }

        public async Task AddTitleStudentAsync(TitleEntity title)
        {
            await AddAsync(title);

            await SaveChangesAsync();
        }

        public async Task RemoveStudent(int studentId)
        {
            //Para eliminar una entidad primero necesito encontrarla en el contexto
            //y luego la elimino.
            var student = await Students.FindAsync(studentId);

            student.State = false;

            Students.Update(student);

            await SaveChangesAsync();
        }

        public async Task SaveStudent()
        {
            await SaveChangesAsync();
        }
    }
}
