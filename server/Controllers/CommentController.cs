using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ICommentData _commentData;
        public CommentController(ICommentData commentData)
        {
            _commentData = commentData;
        }

        // GET: api/<CommentController>
        [HttpGet]
        public IActionResult GetComments()
        {
            var comments = _commentData.GetComments();
            return Ok(comments);
        }

        // GET api/<CommentController>/5
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var comment = _commentData.GetComment(id);  
            return Ok(comment);
        }

        // POST api/<CommentController>
        [Authorize]
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
           comment = _commentData.AddComment(comment);
            return Ok(comment);
        }

        // PUT api/<CommentController>/5
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateComment(int id, Comment comment)
        {
            if (comment != null)
            {
                comment.Id = id;
                comment = _commentData.UpdateComment(comment);
                return Ok(comment);
            }
            return BadRequest();
        }

        // DELETE api/<CommentController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            _commentData.DeleteComment(id);
            return Ok();
        }
    }
}
