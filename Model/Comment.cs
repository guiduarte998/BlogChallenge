using System.ComponentModel.DataAnnotations;


namespace Model
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public int BlogPostId { get; set; }
    }
}