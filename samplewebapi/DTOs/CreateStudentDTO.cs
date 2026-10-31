using System.ComponentModel.DataAnnotations;

namespace samplewebapi.DTOs
{
    public class CreateStudentDTO
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Range(19, 30)]
        public int Age { get; set; }
    }
}
