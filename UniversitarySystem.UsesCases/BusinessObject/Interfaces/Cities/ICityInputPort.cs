namespace UniversitarySystem.UsesCases.BusinessObject.Interfaces.Cities
{
    public interface ICityInputPort
    {
        Task GetListCitiesByProvinceId(int idProvince);
    }
}
