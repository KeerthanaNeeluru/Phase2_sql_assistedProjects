using System.ComponentModel.DataAnnotations;

namespace P3S4ValidationWithDataAnnotations.Models
{
    public class Student
    {
        [Required]
        [StringLength(100,ErrorMessage ="Nmae is reqired")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Class { get; set; }
        [Required]
        [StringLength ( 100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(5,14)]
        public int Age { get;set; }
    }
}
