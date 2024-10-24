using Microsoft.EntityFrameworkCore;
using MoviePreferencesAPI.Data;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Repositories
{
    public class SugerenciasRepository : ISugerenciasRepository
    {
        private readonly ApplicationDbContext _context;

        public SugerenciasRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Sugerencia> GetSugerenciaByUserIdAsync(int userId)
        {
            return await _context.sugerencias.FirstOrDefaultAsync(s => s.UserId == userId);
        }

        public async Task AddSugerenciaAsync(Sugerencia sugerencia)
        {
            _context.sugerencias.Add(sugerencia);
            await _context.SaveChangesAsync();
        }
    }
}
