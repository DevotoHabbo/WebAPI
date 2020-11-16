using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(16)]
        public string Lastname { get; set; }

    }
}
