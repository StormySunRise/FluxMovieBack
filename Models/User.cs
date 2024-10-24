using System.ComponentModel.DataAnnotations;

namespace MoviePreferencesAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool firstLogin { get; set; }
    }
}
