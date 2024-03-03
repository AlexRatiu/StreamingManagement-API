using StreamingManagement.DAL.DBO;
using Microsoft.EntityFrameworkCore;

namespace StreamingManagement.DAL.Repositories.Interfaces
{
    public interface IActorRepository
    {
        Task Create(Actor actor);

        Task<Actor> GetById(int id_actor);

        Task<List<Actor>> GetAll();

        Task Update(Actor actor);

        Task Delete(int id_actor);
    }
}
