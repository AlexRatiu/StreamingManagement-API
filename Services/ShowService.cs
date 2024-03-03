using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using StreamingManagement.Models;
using StreamingManagement.Models.Enums;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace StreamingManagement.Services
{
    public class ShowService : IShowService
    {
        private readonly IShowRepository _showRepository;

        public ShowService(IShowRepository showRepository)
        {
            _showRepository = showRepository;
        }

        public async Task CreateShow(ShowModel show)
        {
            var newShow = new Show
            {
                id_provider = show.Id_Provider,
                show_name = show.Show_Name,
                season_number = show.Season_Number,
                episode_number = show.Episode_Number
            };

            await _showRepository.Create(newShow);
        }

        public async Task<List<ShowModel>> GetAllShows()
        {
            var shows = await _showRepository.GetAll();

            List<ShowModel> results = new List<ShowModel>();

            foreach (var show in shows)
            {
                var parsedShow = new ShowModel
                {
                    Id_Show = show.id_show,
                    Id_Provider = show.id_provider,
                    Show_Name = show.show_name,
                    Season_Number = show.season_number,
                    Episode_Number = show.episode_number
                };

                results.Add(parsedShow);
            }

            return results;
        }

        public async Task UpdateShow(ShowModel show)
        {
            var showToUpdate = new Show
            {
                id_show = show.Id_Show,
                id_provider = show.Id_Provider,
                show_name = show.Show_Name,
                season_number = show.Season_Number,
                episode_number = show.Episode_Number

            };

            await _showRepository.Update(showToUpdate);
        }

        public async Task DeleteShow(int showId)
        {
            await _showRepository.Delete(showId);
        }
    }
}
