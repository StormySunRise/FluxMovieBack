using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Interfaces
{
    public interface IGeneroRepository
    {
        Task<IEnumerable<Generos>> GetAllGenresAsync();
    }
}
