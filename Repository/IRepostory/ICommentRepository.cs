using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepostory
{
    public interface ICommentRepository
    {
        Comment Add(int blogPostId, Comment comment);
    }
}
