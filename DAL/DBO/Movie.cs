using StreamingManagement.Models.Enums;

namespace StreamingManagement.DAL.DBO
{
    public class Movie
    {
        public int? id_movie { get; set; }
        public int? id_provider { get; set; }
        public string? movie_name { get; set; }
        public string? director_name { get; set; }
        public int category { get; set; }
        public List<Distribution> distributions { get; set; }   
        public Provider provider { get; set; }
    }
}
