using System.ComponentModel.DataAnnotations;

namespace RecruitCatAdekunle.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string? Title { get; set; }      //  Nullable Title property

        [Range(0, double.MaxValue, ErrorMessage = "Minimum salary must be a positive number.")]
        public decimal MinSalary { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Maximum salary must be a positive number.")]
        public decimal MaxSalary { get; set; }

        // Additional properties
        [Required(ErrorMessage = "Job description is required.")]
        [StringLength(1000, ErrorMessage = "Job description cannot be longer than 1000 characters.")]
        public string? JobDescription { get; set; }   // Nullable JobDescription property

    }
}