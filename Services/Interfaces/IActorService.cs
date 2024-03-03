using StreamingManagement.Models;

namespace StreamingManagement.Services.Interfaces
{
    public interface IActorService
    {
        Task CreateActor(ActorModel actor);
        Task<List<ActorModel>> GetAllActors();
        Task UpdateActor(ActorModel actor);
        Task DeleteActor(int actorId);
    }
}
