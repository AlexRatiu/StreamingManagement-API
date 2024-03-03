using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using StreamingManagement.Models;
using StreamingManagement.Models.Enums;
using StreamingManagement.Services.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace StreamingManagement.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task CreateMovie(MovieModel movie)
        {
            var newMovie = new Movie
            {
                id_provider = movie.Id_Provider,
                movie_name = movie.Movie_Name,
                director_name = movie.Director_Name,
                category = (int)movie.Category
            };

            await _movieRepository.Create(newMovie);
        }

        public async Task<List<MovieModel>> GetAllMovies()
        {
            var movies = await _movieRepository.GetAll();

            List<MovieModel> results = new List<MovieModel>();

            foreach (var movie in movies)
            {
                var parsedMovie = new MovieModel
                {
                    Id_Movie = movie.id_movie,
                    Id_Provider = movie.id_provider,
                    Movie_Name = movie.movie_name,
                    Director_Name = movie.director_name,
                    Category= (MovieTypes)movie.category
                };

                results.Add(parsedMovie);
            }

            return results;
        }

        public async Task UpdateMovie(MovieModel movie)
        {
            var movieToUpdate = new Movie
            {
                id_movie = movie.Id_Movie,
                id_provider = movie.Id_Provider,
                movie_name = movie.Movie_Name,
                director_name = movie.Director_Name,
                category = (int)movie.Category
            };

            await _movieRepository.Update(movieToUpdate);
        }

        public async Task DeleteMovie(int movieId)
        {
            await _movieRepository.Delete(movieId);
        }
    }
}
