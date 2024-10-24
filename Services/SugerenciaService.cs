using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Services
{
    public class SugerenciaService : ISugerenciasService
    {
        private readonly ISugerenciasRepository _sugerenciasRepository;

        public SugerenciaService(ISugerenciasRepository sugerenciasRepository)
        {
            _sugerenciasRepository = sugerenciasRepository;
        }

        public async Task<SugerenciaDto> GetSugerenciasByUserIdAsync(int userId)
        {
            var sugerencia = await _sugerenciasRepository.GetSugerenciaByUserIdAsync(userId);
            if (sugerencia == null)
            {
                return null;
            }
            return new SugerenciaDto
            {
                genPreferidos = sugerencia.genPreferidos,
                userId = sugerencia.UserId
            };
        }

        public async Task<SugerenciaDto> CreateSugerenciaAsync(SugerenciaDto sugerenciaDto)
        {
            var existingSugerencia = await _sugerenciasRepository.GetSugerenciaByUserIdAsync(sugerenciaDto.userId);
            if (existingSugerencia != null)
            {
                throw new InvalidOperationException("Ya existe una sugerencia para este userId.");
            }

            var sugerencia = new Sugerencia
            {
                genPreferidos = sugerenciaDto.genPreferidos,
                UserId = sugerenciaDto.userId
            };

            await _sugerenciasRepository.AddSugerenciaAsync(sugerencia);

            return new SugerenciaDto
            {
                genPreferidos = sugerencia.genPreferidos,
                userId = sugerencia.UserId
            };
        }
    }
}
