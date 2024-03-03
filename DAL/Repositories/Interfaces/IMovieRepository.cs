using StreamingManagement.DAL.DBO;
using Microsoft.EntityFrameworkCore;

namespace StreamingManagement.DAL.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task Create(Movie movie);

        Task<Movie> GetById(int id_movie);

        Task<List<Movie>> GetAll();

        Task Update(Movie movie);

        Task Delete(int id_movie);
    }
}
