using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Space.Backend.Models.Enteties
{

    [Table("User")]
    public class User
    {
        [Key]
        [Required]
        int Id { get; set; }

        [Required]
        [StringLength(50)]
        string Name { get; set; }

        [Required]
        [StringLength(50)]
        string Email { get; set; }

        [Required]
        [StringLength(50)]
        string Password_Hash { get; set; }

    }
}
