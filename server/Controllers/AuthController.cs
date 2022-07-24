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
        private IUserData _userData;
        public AuthController(IjwtAuthManager jwtAuthManager,IUserData userData)
        {
            _jwtAuthManager = jwtAuthManager;
            _userData = userData;
        }

        // POST api/<AuthController>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AuthUser(UserCred user)
        {
            var _user = _userData.GetUserByEmail(user.Email);
            var token = _jwtAuthManager.Authenticate(_user.Email, _user.Name,_user.Id);
            return Ok(token);
        }
    }
}
