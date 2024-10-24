using MoviePreferencesAPI.DTos;
using MoviePreferencesAPI.Models;

namespace MoviePreferencesAPI.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        Task AddUser(User user);
        Task<User> GetUserByEmail(string email);
        Task<List<User>> GetAllUsersAsync();
    }

   
}
