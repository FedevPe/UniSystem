using System.Reflection.Metadata.Ecma335;
using UniversitarySystem.UsesCases.Aggregates;
using UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student;

namespace UniversitarySystemPresenters.Implementations
{
    public class StudentPresenter : IStudentOutputPort
    {
        public bool IsSaved { get; private set; } = false;
        public Task Handle(CreateStudentAggregate student)
        {
            if (student.IdStudent != 0)
                IsSaved = true;

            return Task.CompletedTask;
        }
    }
}
