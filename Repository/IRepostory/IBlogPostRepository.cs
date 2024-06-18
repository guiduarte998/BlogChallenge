using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepostory
{
    public interface IBlogPostRepository
    {

        BlogPost Add(BlogPost blogPost);
        BlogPost GetById(int id);
        IEnumerable<BlogPost> GetAll();
    }
}
