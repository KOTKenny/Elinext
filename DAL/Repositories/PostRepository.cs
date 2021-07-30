using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public Post GetPost(int id, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            
    }
}
