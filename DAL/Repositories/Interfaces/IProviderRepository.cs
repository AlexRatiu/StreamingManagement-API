using StreamingManagement.DAL.DBO;
using Microsoft.EntityFrameworkCore;

namespace StreamingManagement.DAL.Repositories.Interfaces
{
    public interface IProviderRepository
    {
        Task Create(Provider provider);

        Task<Provider> GetById(int id_provider);

        Task<List<Provider>> GetAll();

        Task Update(Provider provider);

        Task Delete(int id_provider);
    }
}
