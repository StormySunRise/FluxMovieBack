using MoviePreferencesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviePreferencesAPI.Interfaces
{
    public interface IMoviesRepository
    {
        Task<List<Movies>> GetMoviesByGenreIdAsync(int genreId);

        Task<List<Movies>> GetAllMoviesAsync();
    }
}
