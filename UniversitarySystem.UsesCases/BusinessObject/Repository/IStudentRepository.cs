using UniversitarySystem.UsesCases.Aggregates;

namespace UniversitarySystem.UsesCases.BusinessObject.Repository
{
    public interface IStudentRepository
    {
        Task AddStudent(CreateStudentAggregate studentRegistry);
    }
}
