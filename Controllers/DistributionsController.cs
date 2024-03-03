using StreamingManagement.Models;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace StreamingManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistributionsController
    {
        private readonly IDistributionService _distributionService;

        public DistributionsController(IDistributionService distributionService)
        {
            _distributionService = distributionService;
        }

        [HttpPost("[action]")]
        public async Task AddDistribution(DistributionModel distribution)
        {
            await _distributionService.CreateDistribution(distribution);
        }

        [HttpGet("[action]")]
        public async Task<List<DistributionModel>> GetAllDistributions()
        {
            return await _distributionService.GetAllDistributions();
        }

        [HttpPatch("[action]")]
        public async Task UpdateDistribution(DistributionModel distribution)
        {
            await _distributionService.UpdateDistribution(distribution);
        }

        [HttpDelete("[action]")]
        public async Task DeleteDistribution(int distributionId)
        {
            await _distributionService.DeleteDistribution(distributionId);
        }
    }
}
