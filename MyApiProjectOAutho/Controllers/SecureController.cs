using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApiProjectOAutho.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SecureController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You have accessed secured API endpoint.");
        }
    }
}
