using UniversitarySystem.UsesCases.Aggregates;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student
{
    public interface IStudentOutputPort
    {
        int IdStudent { get; }
        Task Handle(CreateStudentAggregate studient);
    }
}
