using MoviePreferencesAPI.DTos;

namespace MoviePreferencesAPI.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetUserById(int id);
        Task<UserDto> Register(UserDto userDto);
        Task<IEnumerable<UserDto>> GetAllUsers();
    }
}
