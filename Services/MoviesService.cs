using Microsoft.EntityFrameworkCore;
using MoviePreferencesAPI.Data;
using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePreferencesAPI.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly ApplicationDbContext _context;

        private readonly IMoviesRepository _moviesRepository;

        public MoviesService(ApplicationDbContext context, IMoviesRepository moviesRepository)
        {
            _context = context;
            _moviesRepository = moviesRepository;
        }

        public async Task<List<MoviesDto>>GetAllMovies()
        {
            return await _context.movies
                .Select(movies => new MoviesDto
                {
                    movieId = movies.movieId,
                    genreId = movies.genreId,
                    title = movies.title,
                    description = movies.description,
                    imageUrl = movies.imageUrl
                   
                })
                .ToListAsync();
        }

        public async Task<List<MoviesDto>> GetMoviesByGenreIdAsync(int genreId)
        {
            var movies = await _moviesRepository.GetMoviesByGenreIdAsync(genreId);
            if (movies == null || !movies.Any())
            {
                return null;
            }

            return movies.Select(m => new MoviesDto
            {
                movieId = m.movieId,
                genreId = m.genreId,
                title = m.title,
                description = m.description,
                imageUrl = m.imageUrl
            }).ToList();
        }
    }
}
