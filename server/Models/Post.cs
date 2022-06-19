using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 30, ErrorMessage = "Title must be between 30 and 200")]
        public string Title { get; set; }
        [Required]
        [StringLength(20000, MinimumLength = 30, ErrorMessage = "Body must be between 30 and 20000")]
        public string Body { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public int Views { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime EditedDate { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
