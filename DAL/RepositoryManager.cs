using DAL.Repositories;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IPostRepository _postRepository;
        private ICommentRepository _commentRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IPostRepository Post
        {
            get
            {
                if (_postRepository == null)
                    _postRepository = new PostRepository(_repositoryContext);

                return _postRepository;
            }
        }

        public ICommentRepository Comment
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new CommentRepository(_repositoryContext);

                return _commentRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
