using StreamingManagement.Models;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace StreamingManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost("[action]")]
        public async Task AddMovie(MovieModel movie)
        {
            await _movieService.CreateMovie(movie);
        }

        [HttpGet("[action]")]
        public async Task<List<MovieModel>> GetAllMovies()
        {
            return await _movieService.GetAllMovies();
        }

        [HttpPatch("[action]")]
        public async Task UpdateMovie(MovieModel movie)
        {
            await _movieService.UpdateMovie(movie);
        }

        [HttpDelete("[action]")]
        public async Task DeleteMovie(int movieId)
        {
            await _movieService.DeleteMovie(movieId);
        }
    }
}
