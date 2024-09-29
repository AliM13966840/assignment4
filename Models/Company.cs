using System.ComponentModel.DataAnnotations;

namespace RecruitCatAdekunle.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(200, ErrorMessage = "Company name cannot be longer than 200 characters.")]
        public string? Name { get; set; }   //  Nullable

        [StringLength(100, ErrorMessage = "Position name cannot be longer than 100 characters.")]
        public string? PositionName { get; set; }  // Nullable

        [Range(0, double.MaxValue, ErrorMessage = "Minimum salary must be a positive number.")]
        public decimal MinSalary { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Maximum salary must be a positive number.")]
        public decimal MaxSalary { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }  //  Nullable

        [StringLength(200, ErrorMessage = "Location cannot be longer than 200 characters.")]
        public string? Location { get; set; }  //  Nullable

        // Additional properties
        [Range(1, int.MaxValue, ErrorMessage = "Number of employees must be a positive integer.")]
        public int NumberOfEmployees { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL.")]
        [StringLength(200, ErrorMessage = "Website URL cannot be longer than 200 characters.")]
        public string? WebsiteUrl { get; set; }   // Nullable

    }


}
