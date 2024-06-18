using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Repository.IRepostory;

namespace BlogChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : Controller
    {
        private readonly IBlogPostRepository _blogPostrepository;
        private readonly ICommentRepository _commentRepository;

        public BlogPostsController(IBlogPostRepository blogPostrepository, ICommentRepository commentRepository)
        {
            _blogPostrepository = blogPostrepository;
            _commentRepository = commentRepository;
        }

        // GET: api/posts
        [HttpGet]
        public ActionResult<IEnumerable<object>> GetAll()
        {
            var blogPosts = _blogPostrepository.GetAll();

            var result = blogPosts.Select(bp => new
            {
                Id = bp.Id,
                Title = bp.Title,
                CommentsCount = bp.Comments.Count
            });

            if (blogPosts.Count() == 0)
                return NotFound();

            return Ok(result);
        }

        // POST: api/posts
        [HttpPost]
        public ActionResult<BlogPost> AddBlogPost(BlogPost blogPost)
        {
            var createdPost = _blogPostrepository.Add(blogPost);
            return CreatedAtAction(nameof(GetBlogPostById), new { id = createdPost.Id }, createdPost);
        }

        // GET: api/posts/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<BlogPost>> GetBlogPostById(int id)
        {
            var blogPost = _blogPostrepository.GetById(id);

            if (blogPost == null)
            {
                return NotFound();
            }

            return Ok(blogPost);
        }

        // POST: api/posts/{id}/comments
        [HttpPost("{id}/comments")]
        public ActionResult<Comment> AddComment(int id, Comment comment)
        {
            var addedComment = _commentRepository.Add(id, comment);

            if (addedComment == null)
            {
                return NotFound();
            }

            return CreatedAtAction(nameof(GetBlogPostById), new { id = id }, addedComment);
        }

    }
}
