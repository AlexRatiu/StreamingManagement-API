namespace StreamingManagement.DAL.DBO
{
    public class Distribution
    {
        public int? id_distribution {  get; set; }
        public int? id_actor { get; set; }
        public int? id_movie { get; set; }
        public Actor actor { get; set; }
        public Movie movie { get; set; }    
    }
}
