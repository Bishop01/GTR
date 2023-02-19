
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("Get")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new {Status=200, Message="Works"});
        }
    }
}
