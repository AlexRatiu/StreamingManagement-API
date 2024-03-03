using StreamingManagement.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StreamingManagement.Models
{
    public class ShowModel
    {
        public int? Id_Show { get; set; }
        public int? Id_Provider { get; set; }

        [StringLength(50, ErrorMessage = "Invalid name!")]
        public string? Show_Name { get; set; }

        [DefaultValue(0)]
        [Range(0, 99, ErrorMessage = "Invalid season number!")]
        public int Season_Number { get; set;}

        [DefaultValue(0)]
        [Range(0, 99999, ErrorMessage = "Invalid episode number!")]
        public int Episode_Number { get; set; }
    }
}
