using StreamingManagement.Models;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace StreamingManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowsController
    {
        private readonly IShowService _showService;

        public ShowsController(IShowService showService)
        {
            _showService = showService;
        }

        [HttpPost("[action]")]
        public async Task AddShow(ShowModel show)
        {
            await _showService.CreateShow(show);
        }

        [HttpGet("[action]")]
        public async Task<List<ShowModel>> GetAllShows()
        {
            return await _showService.GetAllShows();
        }

        [HttpPatch("[action]")]
        public async Task UpdateShow(ShowModel show)
        {
            await _showService.UpdateShow(show);
        }

        [HttpDelete("[action]")]
        public async Task DeleteShow(int showId)
        {
            await _showService.DeleteShow(showId);
        }
    }
}
