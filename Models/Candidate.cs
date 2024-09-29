using System.ComponentModel.DataAnnotations;

namespace RecruitCatAdekunle.Models
{
    public class Candidate
    {
        public int Id { get; set; }  // Primary Key (no validation needed)

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FirstName { get; set; }  // First name is required and limited in length

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100, ErrorMessage = "Last name cannot be longer than 100 characters.")]
        public string LastName { get; set; }  // Last name is required and limited in length

        [Range(0, double.MaxValue, ErrorMessage = "Target salary must be a positive number.")]
        public decimal TargetSalary { get; set; }  // Must be a positive number

        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public DateTime? StartDate { get; set; }  // Optional (nullable)

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public DateTime DateOfBirth { get; set; }  // Required and must be a valid date

        public bool IsCurrentlyEmployed { get; set; }  // No validation needed for boolean

        // Foreign Key to JobTitle
        [Required(ErrorMessage = "Job title is required.")]
        public int JobTitleId { get; set; }  // Required Foreign Key to JobTitle

        // Navigation Property
        public JobTitle? JobTitle { get; set; }  // Navigation property (nullable)
    }


}
