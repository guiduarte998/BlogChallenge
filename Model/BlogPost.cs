using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
