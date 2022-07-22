using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 10)]
        public string Password { get; set; }
        public int Reputation { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
