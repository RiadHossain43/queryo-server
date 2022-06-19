using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserData _userData;
        public UserController(IUserData userData)
        {
            _userData = userData;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userData.GetUsers();
            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userData.GetUserById(id);
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userData.AddUser(user);
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            if (user != null)
            {
                user.Id = id;
                user = _userData.UpdateUser(user);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userData.DeleteUser(id);
            return Ok();
        }
    }
}
