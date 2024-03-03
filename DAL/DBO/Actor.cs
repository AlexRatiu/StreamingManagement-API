namespace StreamingManagement.DAL.DBO
{
    public class Actor
    {
        public int? id_actor { get; set; }
        public string? actor_name { get; set; }
        public string? actor_surname { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public int gender { get; set; }
        public List<Distribution> distributions { get; set; } 
    }
}
