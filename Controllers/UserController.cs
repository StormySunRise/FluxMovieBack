using Microsoft.AspNetCore.Mvc;
using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Interfaces;
using System.Threading.Tasks;

namespace MoviePreferencesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest("User data is null.");
            }

            var result = await _userService.Register(userDto);
            if (result == null)
            {
                return BadRequest("Email already registered"); // Manejo de errores
            }

            return Ok(result); // Devolver el UserDto que ahora incluye el Id
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null) 
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpGet("all")] // Endpoint para obtener todos los usuarios
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }
    }
}
