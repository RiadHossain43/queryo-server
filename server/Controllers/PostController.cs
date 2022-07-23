using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostData _postData;
        public PostController(IPostData postData)
        {
            _postData = postData;
        }
        // GET: api/<PostController>
        [HttpGet]
        public IActionResult GetPosts()
        {
            return Ok(_postData.GetPosts());
        }

        // GET: api/<PostController>
        [HttpGet("answers/{id}")]
        public IActionResult GetPostsByRefId(int id)
        {
            return Ok(_postData.GetPostsByRefId(id));
        }

        // GET api/<PostController>/5s
        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var post = _postData.GetPost(id);
            return Ok(post);
        }

        // POST api/<PostController>
        [Authorize]
        [HttpPost]
        public IActionResult AddPost(Post post)
        {
            if (post != null)
            {
                post = _postData.AddPost(post);
                return Ok(post);
            }
            return BadRequest();
        }

        // PUT api/<PostController>/5
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdatePost(int id, Post post)
        {
            if (post != null)
            {
                post.Id = id;
                post.EditedDate = DateTime.Now;
                post = _postData.UpdatePost(post);
                return Ok(post);
            }
            return BadRequest();
        }

        // DELETE api/<PostController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            _postData.DeletePost(id);
            return Ok();
        }
    }
}
