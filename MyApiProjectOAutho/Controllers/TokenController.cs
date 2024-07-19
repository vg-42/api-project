using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApiProjectOAutho.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TokenController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetToken()
        {
            var accessToken = HttpContext.GetTokenAsync("access_token").Result;
            return Ok(new { access_token = accessToken });
        }
    }
}

