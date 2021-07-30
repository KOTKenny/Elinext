using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        void CreateComment(Comment comment);
        IEnumerable<Comment> GetCommentsByPostId(int postId, bool trackChanges);
        IEnumerable<Comment> GetRepliesByCommentId(int commentId, bool trackChanges);
    }
}
