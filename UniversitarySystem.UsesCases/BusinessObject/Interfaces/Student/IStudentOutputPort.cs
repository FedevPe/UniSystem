using UniversitarySystem.UsesCases.Aggregates;

namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.Student
{
    public interface IStudentOutputPort
    {
        public bool IsSaved { get; }
        Task Handle(CreateStudentAggregate studient);
    }
}
