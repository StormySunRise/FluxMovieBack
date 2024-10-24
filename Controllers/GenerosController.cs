using Microsoft.AspNetCore.Mvc;
using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Interfaces;

namespace MoviePreferencesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerosController : ControllerBase
    {
            private readonly IGenerosService _generosService;

            public GenerosController(IGenerosService generosService)
            {
                _generosService = generosService;
            }

            [HttpGet("all")] // Endpoint para obtener todos los usuarios
            public async Task<IActionResult> GetAllGeneros()
            {
                var users = await _generosService.GetAllGeneros();
                return Ok(users);
            }
        }
}
