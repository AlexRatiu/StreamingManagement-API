using StreamingManagement.Models.Enums;

namespace StreamingManagement.DAL.DBO
{
    public class Provider
    {
        public int? id_provider { get; set; }
        public string? provider_name { get; set; }
        public int movie_number { get; set; }
        public int show_number { get; set; }
        public int cost { get; set; }
        public List<Movie> movies { get; set; }
        public List<Show> shows { get; set; }
    }
}
