using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateComment(Comment comment) => Create(comment);

        public IEnumerable<Comment> GetCommentsByPostId(int postId, bool trackChanges) =>
            FindByCondition(p => p.PostId.Equals(postId), trackChanges);

        public IEnumerable<Comment> GetRepliesByCommentId(int commentId, bool trackChanges) =>
            FindByCondition(p => p.CommentId.Equals(commentId), trackChanges);

    }
}
