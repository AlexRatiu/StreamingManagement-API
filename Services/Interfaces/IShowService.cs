using StreamingManagement.Models;

namespace StreamingManagement.Services.Interfaces
{
    public interface IShowService
    {
        Task CreateShow(ShowModel show);
        Task<List<ShowModel>> GetAllShows();
        Task UpdateShow(ShowModel show);
        Task DeleteShow(int showId);
    }
}
