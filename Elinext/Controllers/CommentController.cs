using DAL;
using DAL.Models;
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
    public class CommentController : ControllerBase
    {
        private IRepositoryManager _repository;

        public CommentController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}/replies")]
        public IActionResult GetByCompanyId(int id)
        {
            var replies = _repository.Comment.GetRepliesByCommentId(id, trackChanges: false);

            if (replies == null)
                return NotFound();

            return Ok(replies);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Comment comment)
        {
            if (comment == null)
                return BadRequest("Comment object in null");

            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }

            _repository.Comment.CreateComment(comment);
            _repository.Save();

            return Ok();
        }
    }
}
