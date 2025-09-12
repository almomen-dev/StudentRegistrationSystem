using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(16, 65, ErrorMessage = "Age must be between 16 and 65")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }
    }
}
