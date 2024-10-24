using Microsoft.AspNetCore.Mvc;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Services;

namespace MoviePreferencesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet("{genreId}")]
        public async Task<IActionResult> GetMoviesByGenreIdAsync(int genreId)
        {
            var movies = await _moviesService.GetMoviesByGenreIdAsync(genreId);
            if (movies == null)
            {
                return NotFound();
            }
            return Ok(movies);
        }

        [HttpGet("all")] // Endpoint para obtener todos los usuarios
        public async Task<IActionResult> GetAllMovies()
        {
            var users = await _moviesService.GetAllMovies();
            return Ok(users);
        }
    }
}
