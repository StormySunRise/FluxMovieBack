using Microsoft.AspNetCore.Mvc;
using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Interfaces;

namespace MoviePreferencesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SugerenciasController : ControllerBase
    {
        private readonly ISugerenciasService _sugerenciaService;

        public SugerenciasController(ISugerenciasService sugerenciaService)
        {
            _sugerenciaService = sugerenciaService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetSugerenciasByUserIdAsync(int userId)
        {
            var sugerencias = await _sugerenciaService.GetSugerenciasByUserIdAsync(userId);
            if (sugerencias == null)
            {
                return NotFound();
            }
            return Ok(sugerencias);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSugerenciaAsync(SugerenciaDto sugerenciaCreateDto)
        {
            if (sugerenciaCreateDto == null)
            {
                return BadRequest("User data is null.");
            }
            var sugerencia = await _sugerenciaService.CreateSugerenciaAsync(sugerenciaCreateDto);

            // Simplificar para verificar
            return Ok(sugerencia); ;

        }
    }
}
