using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace StreamingManagement.DAL.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly StreamingDbContext _dbContext;

        public ActorRepository(StreamingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Actor actor)
        {
            await _dbContext.Actor.AddAsync(actor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Actor> GetById(int id_actor)
        {
            return await _dbContext.Actor.FindAsync(id_actor);
        }

        public async Task<List<Actor>> GetAll()
        {
            var results = _dbContext.Actor.ToList();
            return results;
        }

        public async Task Update(Actor actor)
        {
            _dbContext.Actor.Entry(actor).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id_actor)
        {
            var result = await this.GetById(id_actor);

            if (result != null)
            {
                _dbContext.Actor.Remove(result);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
