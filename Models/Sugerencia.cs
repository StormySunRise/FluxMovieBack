namespace MoviePreferencesAPI.Models
{
    public class Sugerencia
    {
        public int sugerenciaId { get; set; }
        public int UserId { get; set; }
        public List<int> genPreferidos { get; set; }
    }
}
