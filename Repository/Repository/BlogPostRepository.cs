using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Context;
using Repository.IRepostory;

namespace Repository.Repository
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BlogContext _context;


        public BlogPostRepository(BlogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public BlogPost Add(BlogPost blogPost)
        {
            _context.BlogPosts.Add(blogPost);
            _context.SaveChanges();
            return blogPost;
        }

        public BlogPost GetById(int id)
        {
            return _context.BlogPosts
                .Include(bp => bp.Comments)
                .FirstOrDefault(bp => bp.Id == id);
        }

        public IEnumerable<BlogPost> GetAll()
        {
            return _context.BlogPosts
                .Include(bp => bp.Comments)
                .ToList();
        }
    }
}
