using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace StreamingManagement.DAL.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly StreamingDbContext _dbContext;

        public MovieRepository(StreamingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Movie movie)
        {
            await _dbContext.Movie.AddAsync(movie);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Movie> GetById(int id_movie)
        {
            return await _dbContext.Movie.FindAsync(id_movie);
        }

        public async Task<List<Movie>> GetAll()
        {
            var results = _dbContext.Movie.ToList();
            return results;
        }

        public async Task Update(Movie movie)
        {
            _dbContext.Movie.Entry(movie).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id_movie)
        {
            var result = await this.GetById(id_movie);

            if (result != null)
            {
                _dbContext.Movie.Remove(result);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
