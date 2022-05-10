using System.ComponentModel.DataAnnotations;

namespace GoglikaRazor.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [Range(18, 150, ErrorMessage = "You must be 18 years old")]
        public int Age { get; set; }
        public string Address { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
