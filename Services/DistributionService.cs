using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using StreamingManagement.Models;
using StreamingManagement.Models.Enums;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace StreamingManagement.Services
{
    public class DistributionService : IDistributionService
    {
        private readonly IDistributionRepository _distributionRepository;

        public DistributionService(IDistributionRepository distributionRepository)
        {
            _distributionRepository = distributionRepository;
        }

        public async Task CreateDistribution(DistributionModel distribution)
        {
            var newDistribution = new Distribution
            {
                id_actor=distribution.Id_Actor,
                id_movie=distribution.Id_Movie
            };

            await _distributionRepository.Create(newDistribution);
        }

        public async Task<List<DistributionModel>> GetAllDistributions()
        {
            var distributions = await _distributionRepository.GetAll();

            List<DistributionModel> results = new List<DistributionModel>();

            foreach (var distribution in distributions)
            {
                var parsedDistribution = new DistributionModel
                {
                    Id_Distribution = distribution.id_distribution,
                    Id_Actor = distribution.id_actor,
                    Id_Movie = distribution.id_movie
                    
                };

                results.Add(parsedDistribution);
            }

            return results;
        }

        public async Task UpdateDistribution(DistributionModel distribution)
        {
            var distributionToUpdate = new Distribution
            {
                id_distribution = distribution.Id_Distribution,
                id_actor = distribution.Id_Actor,
                id_movie = distribution.Id_Movie
            };

            await _distributionRepository.Update(distributionToUpdate);
        }

        public async Task DeleteDistribution(int distributionId)
        {
            await _distributionRepository.Delete(distributionId);
        }
    }
}
