using Microsoft.EntityFrameworkCore;
using MoviePreferencesAPI.Data;
using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Interfaces;
using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRepository _userRepository;

        public UserService(ApplicationDbContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository; // Asegúrate de que esto se inicializa
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            return await _context.Users
                .Select(user => new UserDto
                {
                    Id = user.Id,
                    Username = user.Username,
                    Email = user.Email,
                    firstLogin = user.firstLogin,
                    Password = user.PasswordHash
                })
                .ToListAsync();
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);
            return new UserDto { Username = user.Username, Email = user.Email , Password = user.PasswordHash };
        }

        public async Task<UserDto> Register(UserDto userDto)
        {
            // Verificar si el email ya existe en la base de datos
            var existingUser = await _userRepository.GetUserByEmail(userDto.Email);
            if (existingUser != null)
            {
                return null; // Manejo de errores
            }

            var user = new User
            {
                Username = userDto.Username,
                Email = userDto.Email,
                PasswordHash = HashPassword(userDto.Password),
                firstLogin = userDto.firstLogin
            };

            await _userRepository.AddUser(user);

            // Devolver el UserDto con el Id generado
            userDto.Id = user.Id; // Asignar el Id generado al UserDto
            return userDto; // Devolver el UserDto
        }


        private string HashPassword(string password)
        {
            return password;
        }
    }
}
