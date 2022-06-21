using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Post")]
        public int PostId { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Title must be between 10 and 500")]
        public string Body { get; set; }
        public int UpVote { get; set; }
        public int Flag { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        [ForeignKey("User")]
        public int CreatedBy { get; set; }
    }
}
