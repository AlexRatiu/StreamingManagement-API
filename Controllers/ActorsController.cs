using StreamingManagement.Models;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace StreamingManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorsController
    {
        private readonly IActorService _actorService;

        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpPost("[action]")]
        public async Task AddActor(ActorModel actor)
        {
            await _actorService.CreateActor(actor);
        }

        [HttpGet("[action]")]
        public async Task<List<ActorModel>> GetAllActors()
        {
            return await _actorService.GetAllActors();
        }

        [HttpPatch("[action]")]
        public async Task UpdateActor(ActorModel actor)
        {
            await _actorService.UpdateActor(actor);
        }

        [HttpDelete("[action]")]
        public async Task DeleteActor(int actorId)
        {
            await _actorService.DeleteActor(actorId);
        }
    }
}
