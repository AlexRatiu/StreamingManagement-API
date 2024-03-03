using StreamingManagement.Models;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace StreamingManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProvidersController
    {
        private readonly IProviderService _providerService;

        public ProvidersController(IProviderService providerService)
        {
            _providerService = providerService;
        }

        [HttpPost("[action]")]
        public async Task AddProvider(ProviderModel provider)
        {
            await _providerService.CreateProvider(provider);
        }

        [HttpGet("[action]")]
        public async Task<List<ProviderModel>> GetAllProviders()
        {
            return await _providerService.GetAllProviders();
        }

        [HttpPatch("[action]")]
        public async Task UpdateProvider(ProviderModel provider)
        {
            await _providerService.UpdateProvider(provider);
        }

        [HttpDelete("[action]")]
        public async Task DeleteProvider(int providerId)
        {
            await _providerService.DeleteProvider(providerId);
        }
    }
}
