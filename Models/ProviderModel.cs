using StreamingManagement.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StreamingManagement.Models
{
    public class ProviderModel
    {
        public int? Id_Provider { get; set; }

        [StringLength(50, ErrorMessage = "Invalid name!")]
        public string? Provider_Name { get; set; }

        [DefaultValue(0)]
        [Range(0, 99999, ErrorMessage = "Invalid movie number!")]
        public int Movie_Number { get; set; }

        [DefaultValue(0)]
        [Range(0, 99999, ErrorMessage = "Invalid show number!")]
        public int Show_Number { get; set; }

        [DefaultValue(0)]
        [Range(0, 150, ErrorMessage = "Invalid cost value!")]
        public int Cost { get; set; }
    }
}
