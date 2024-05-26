using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return Ok("Hello, World!");
        }
    }
}
