using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Jwt.Models;

namespace WebAPI.Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult CreateToken()
        {
            return Ok(new Token().Create());
        }
        [HttpGet("[action]")]
        public IActionResult CreateAdminToken()
        {
            return Ok(new Token().CreateAdmin());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult LoginToken()
        {
            return Ok("Token ile giriş yapıldı");
        }
        [Authorize(Roles ="Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult LoginAdminToken()
        {
            return Ok("Admin token ile giriş yaptı");
        }

    }
}
