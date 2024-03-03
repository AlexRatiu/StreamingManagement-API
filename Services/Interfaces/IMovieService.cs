using StreamingManagement.Models;

namespace StreamingManagement.Services.Interfaces
{
    public interface IMovieService
    {
        Task CreateMovie(MovieModel movie);
        Task<List<MovieModel>> GetAllMovies();
        Task UpdateMovie(MovieModel movie);
        Task DeleteMovie(int movieId);
    }
}
