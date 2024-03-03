using StreamingManagement.Models;

namespace StreamingManagement.Services.Interfaces
{
    public interface IDistributionService
    {
        Task CreateDistribution(DistributionModel distribution);
        Task<List<DistributionModel>> GetAllDistributions();
        Task UpdateDistribution(DistributionModel distribution);
        Task DeleteDistribution(int distributionId);
    }
}
