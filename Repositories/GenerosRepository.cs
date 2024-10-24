using Microsoft.EntityFrameworkCore;
using MoviePreferencesAPI.Data;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Repositories
{
    public class GenerosRepository : IGeneroRepository
    {
        private readonly ApplicationDbContext _context;

        public GenerosRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Generos>> GetAllGenresAsync()
        {
            return await _context.Genres.ToListAsync();
        }
    }
}
