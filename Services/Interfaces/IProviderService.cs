using StreamingManagement.Models;

namespace StreamingManagement.Services.Interfaces
{
    public interface IProviderService
    {
        Task CreateProvider(ProviderModel provider);
        Task<List<ProviderModel>> GetAllProviders();
        Task UpdateProvider(ProviderModel provider);
        Task DeleteProvider(int providerId);
    }
}
