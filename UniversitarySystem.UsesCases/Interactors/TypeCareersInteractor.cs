using UniversitarySystem.UsesCases.BusinessObject.Interfaces.TypeCareers;
using UniversitarySystem.UsesCases.BusinessObject.Repository;

namespace UniversitarySystem.UsesCases.Interactors
{
    public class TypeCareersInteractor
        (ITypeCareersOutputPort presenter,
        ITypeCareersRepository repository) : ITypeCareersInputPort
    {
        public async Task GetAllTypeCareers()
        {
            await presenter.HandleList(await repository.GetListTypeCareers());
        }

        public async Task GetTypeCareersById(int id)
        {
            await presenter.Handle(await repository.GetTypeById(id));
        }
    }
}
