using Microsoft.EntityFrameworkCore;
using MoviePreferencesAPI.Data;
using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Services
{
    public class GenerosService : IGenerosService
    {
        private readonly ApplicationDbContext _context;
        private readonly IGeneroRepository _generoRepository;

        public GenerosService(ApplicationDbContext context, IGeneroRepository generoRepository)
        {
            _context = context;
            _generoRepository = generoRepository;
        }

        public async Task<IEnumerable<GenerosDto>> GetAllGeneros()
        {
            return await _context.Genres
                .Select(generos => new GenerosDto
                {
                    GenreId = generos.GenreId,
                    GenreName = generos.GenreName,
                    ImageUrl = generos.ImageUrl,
                })
                .ToListAsync();
        }

    }
}
