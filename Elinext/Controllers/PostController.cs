using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IRepositoryManager _repository;

        public PostController(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var post = _repository.Post.GetPost(id, trackChanges: false);

            if (post == null)
                return NotFound();

            return Ok(post);
        }

        [HttpGet("{id}/comments")]
        public IActionResult GetCommentsByPostId(int id)
        {
            var post = _repository.Post.GetPost(id, trackChanges: false);

            if (post == null)
                return NotFound();

            var comments = _repository.Comment.GetCommentsByPostId(post.Id, trackChanges: false);

            if (comments == null)
                return NotFound();

            return Ok(comments);
        }
    }
}
