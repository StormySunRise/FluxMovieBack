using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Interfaces
{
    public interface ISugerenciasRepository
    {
        Task<Sugerencia> GetSugerenciaByUserIdAsync(int userId);
       
        Task AddSugerenciaAsync(Sugerencia sugerencia); 
    }
}
