using UniversitarySystem.Entities.Interfaces;
using UniversitarySystem.UsesCases.Aggregates;

namespace UniversitarySystem.UsesCases.BusinessObject.Repository
{
    public interface IStudentRepository : IUnitOfWork
    {
        Task AddStudent(CreateStudentAggregate studentRegistry);
    }
}
