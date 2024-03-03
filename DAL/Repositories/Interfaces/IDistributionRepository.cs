using StreamingManagement.DAL.DBO;
using Microsoft.EntityFrameworkCore;

namespace StreamingManagement.DAL.Repositories.Interfaces
{
    public interface IDistributionRepository
    {
        Task Create(Distribution distribution);

        Task<Distribution> GetById(int id_distribution);

        Task<List<Distribution>> GetAll();

        Task Update(Distribution distrbuiton);

        Task Delete(int id_distribuiton);
    }
}
