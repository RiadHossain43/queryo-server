using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        public int Email { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 10)]
        public int Password { get; set; }
        public int Reputation { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
