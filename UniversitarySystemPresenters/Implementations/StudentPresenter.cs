using UniversitarySystem.UsesCases.Aggregates;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student;

namespace UniversitarySystemPresenters.Implementations
{
    public class StudentPresenter : IStudentOutputPort
    {
        public int IdStudent {  get; private set; }

        public Task Handle(CreateStudentAggregate student)
        {
            IdStudent = student.IdStudent;
            return Task.CompletedTask;
        }
    }
}
