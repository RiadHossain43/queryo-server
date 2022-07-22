using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Models;
using server.Services;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IjwtAuthManager _jwtAuthManager;
        public AuthController(IjwtAuthManager jwtAuthManager)
        {
            _jwtAuthManager = jwtAuthManager;
        }

        // POST api/<AuthController>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AuthUser(UserCred user)
        {
            var token = _jwtAuthManager.Authenticate(user.Email,user.Password);
            return Ok(token);
        }
    }
}
