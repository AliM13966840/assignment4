using System.ComponentModel.DataAnnotations;

namespace RecruitCatAdekunle.Models
{
    public class Industry
    {
        public int Id { get; set; } // Id property

        [Required(ErrorMessage = "Industry name is required.")]
        [StringLength(100, ErrorMessage = "Industry name cannot be longer than 100 characters.")]
        public string? Name { get; set; } //  Nullable and Name of the industry
    }

}

