using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using StreamingManagement.Models;
using StreamingManagement.Models.Enums;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace StreamingManagement.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _providerRepository;

        public ProviderService(IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }

        public async Task CreateProvider(ProviderModel provider)
        {
            var newProvider = new Provider
            {
                provider_name = provider.Provider_Name,
                movie_number = provider.Movie_Number,
                show_number = provider.Show_Number,
                cost = provider.Cost
            };

            await _providerRepository.Create(newProvider);
        }

        public async Task<List<ProviderModel>> GetAllProviders()
        {
            var providers = await _providerRepository.GetAll();

            List<ProviderModel> results = new List<ProviderModel>();

            foreach (var provider in providers)
            {
                var parsedProvider = new ProviderModel
                {
                    Id_Provider = provider.id_provider,
                    Provider_Name = provider.provider_name,
                    Movie_Number = provider.movie_number,
                    Show_Number = provider.show_number,
                    Cost = provider.cost
                };

                results.Add(parsedProvider);
            }

            return results;
        }

        public async Task UpdateProvider(ProviderModel provider)
        {
            var providerToUpdate = new Provider
            {
                id_provider = provider.Id_Provider,
                provider_name = provider.Provider_Name,
                movie_number = provider.Movie_Number,
                show_number = provider.Show_Number,
                cost = provider.Cost

            };

            await _providerRepository.Update(providerToUpdate);
        }

        public async Task DeleteProvider(int providerId)
        {
            await _providerRepository.Delete(providerId);
        }
    }
}
