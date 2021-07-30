using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces
{
    public interface IPostRepository
    {
        Post GetPost(int id, bool trackChanges);
    }
}
