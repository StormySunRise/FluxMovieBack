using Microsoft.EntityFrameworkCore;
using MoviePreferencesAPI.Data;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviePreferencesAPI.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly ApplicationDbContext _context;

        public MoviesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movies>> GetMoviesByGenreIdAsync(int genreId)
        {
            return await _context.movies.Where(m => m.genreId == genreId).ToListAsync();
        }

        public async Task<List<Movies>> GetAllMoviesAsync()
        {
            return await _context.movies.ToListAsync();
        }
    }
}
