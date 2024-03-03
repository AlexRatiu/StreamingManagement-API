using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using StreamingManagement.Models;
using StreamingManagement.Models.Enums;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace StreamingManagement.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public async Task CreateActor(ActorModel actor)
        {
            var newActor = new Actor
            {
                actor_name = actor.Actor_Name,
                actor_surname = actor.Actor_Surname,
                age = actor.Age,
                salary = actor.Salary,
                gender = (int)actor.Gender
            };

            await _actorRepository.Create(newActor);
        }

        public async Task<List<ActorModel>> GetAllActors()
        {
            var actors = await _actorRepository.GetAll();

            List<ActorModel> results = new List<ActorModel>();

            foreach (var actor in actors)
            {
                var parsedActor = new ActorModel
                {
                    Id_Actor = actor.id_actor,
                    Actor_Name = actor.actor_name,
                    Actor_Surname = actor.actor_surname,
                    Age = actor.age,
                    Salary = actor.salary,
                    Gender = (GenderTypes)actor.gender
                };

                results.Add(parsedActor);
            }

            return results;
        }

        public async Task UpdateActor(ActorModel actor)
        {
            var actorToUpdate = new Actor
            {
                id_actor = actor.Id_Actor,
                actor_name = actor.Actor_Name,
                actor_surname = actor.Actor_Surname,
                age = actor.Age,
                salary = actor.Salary,
                gender = (int)actor.Gender
            };

            await _actorRepository.Update(actorToUpdate);
        }

        public async Task DeleteActor(int actorId)
        {
            await _actorRepository.Delete(actorId);
        }
    }
}
