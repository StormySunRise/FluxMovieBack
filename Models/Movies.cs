using System.ComponentModel.DataAnnotations;

namespace MoviePreferencesAPI.Models
{
    public class Movies
    {
        [Key]
        public int movieId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int genreId { get; set; }
        public string imageUrl { get; set; }
    }
}
