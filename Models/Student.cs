using System.ComponentModel.DataAnnotations;

namespace Authent.Models
{
    public class Student
    {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string FirstName { get; set; }

            [Required]
            [StringLength(50)]
            public string LastName { get; set; }

            [Required]
            [StringLength(10)]
            public string CourseCode { get; set; }

            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
    }
}
