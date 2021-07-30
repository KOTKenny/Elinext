using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IRepositoryManager
    {
        public IPostRepository Post { get; }
        public ICommentRepository Comment { get; }
        public void Save();
    }
}
