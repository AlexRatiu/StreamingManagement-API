using StreamingManagement.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace StreamingManagement.Models
{
    public class ActorModel
    {
        public int? Id_Actor { get; set; }

        [StringLength(50, ErrorMessage = "Invalid name!")]
        public string? Actor_Name { get; set; }

        [StringLength(50, ErrorMessage = "Invalid surname!")]
        public string? Actor_Surname { get; set; }

        [DefaultValue(0)]
        [Range(0, 100, ErrorMessage = "Invalid age!")]
        public int Age { get; set; }

        [DefaultValue(0)]
        [Range(0, 999999, ErrorMessage = "Invalid salary!")]
        public int Salary { get; set; }

        [DefaultValue(0)]
        [Range(0, 1, ErrorMessage = "Invalid gender type!")]
        public GenderTypes Gender { get; set; }
    }
}
