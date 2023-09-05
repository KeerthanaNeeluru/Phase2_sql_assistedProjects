using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P3SectionHttp.Models
{
    [Table("Student")]
    public class Student
    {
       [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Name { get;set; }
        public string Class { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }
    }
}
