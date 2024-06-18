using Model;
using Repository.Context;
using Repository.IRepostory;

namespace Repository.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogContext _context;


        public CommentRepository(BlogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Comment Add(int blogPostId, Comment comment)
        {
            var blogPost = _context.BlogPosts.Find(blogPostId);
            if (blogPost == null)
            {
                return null;
            }

            comment.BlogPostId = blogPostId;
            _context.Comments.Add(comment);
            _context.SaveChanges();

            return comment;
        }
        
    }
}
