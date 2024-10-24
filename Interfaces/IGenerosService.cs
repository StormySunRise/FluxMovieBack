using MoviePreferencesAPI.DTos;

namespace MoviePreferencesAPI.Interfaces
{
    public interface IGenerosService
    {
        Task<IEnumerable<GenerosDto>> GetAllGeneros();
    }
}
