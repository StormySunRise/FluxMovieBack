using MoviePreferencesAPI.DTos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviePreferencesAPI.Interfaces
{
    public interface IMoviesService
    {
        Task<List<MoviesDto>> GetMoviesByGenreIdAsync(int genreId);

        Task<List<MoviesDto>> GetAllMovies();
    }
}
