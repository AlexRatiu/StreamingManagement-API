using StreamingManagement.Models.Enums;

namespace StreamingManagement.DAL.DBO
{
    public class Show
    {
        public int? id_show { get; set; }
        public int? id_provider { get; set; }
        public string? show_name { get; set; }
        public int season_number { get; set; }
        public int episode_number { get; set; }
        public Provider provider { get; set; }
    }
}
