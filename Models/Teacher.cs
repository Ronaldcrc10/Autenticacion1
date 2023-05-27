using System.ComponentModel.DataAnnotations;

namespace Authent.Models
{
    public class Teacher
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
            [StringLength(50)]
            public string Subject { get; set; }

            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
        }
    }
}
