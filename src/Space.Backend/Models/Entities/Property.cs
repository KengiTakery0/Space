using System.ComponentModel.DataAnnotations;

namespace Space.Backend.Models.Entities
{
    public class Property
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
