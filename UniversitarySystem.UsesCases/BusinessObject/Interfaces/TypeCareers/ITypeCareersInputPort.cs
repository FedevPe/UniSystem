namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers
{
    public interface ITypeCareersInputPort
    {
        Task GetAllTypeCareers();
        Task GetTypeCareersById(int id);
    }
}
