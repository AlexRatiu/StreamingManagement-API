using StreamingManagement.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StreamingManagement.Models
{
    public class MovieModel
    {
        public int? Id_Movie { get; set; }
        public int? Id_Provider { get; set; }

        [StringLength(50, ErrorMessage = "Invalid name!")]
        public string? Movie_Name { get; set; }

        [StringLength(50, ErrorMessage = "Invalid name!")]
        public string? Director_Name { get; set; }

        [DefaultValue(0)]
        [Range(0, 5, ErrorMessage = "Invalid movie category!")]
        public MovieTypes Category { get; set; }
    }
}
