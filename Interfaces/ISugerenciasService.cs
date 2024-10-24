using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Interfaces
{
    public interface ISugerenciasService
    {
        Task<SugerenciaDto>GetSugerenciasByUserIdAsync(int userId);

        Task<SugerenciaDto>CreateSugerenciaAsync(SugerenciaDto sugerenciaCreateDto);
    }
}
