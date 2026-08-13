using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(StaticDb.Users);
        }

        [HttpGet("{index:int}")]

        public IActionResult GetUserByIndex(int index)
        {
            if (index < 0 || index > StaticDb.Users.Count -1)
            {
                return NotFound();
            }

            return Ok(StaticDb.Users[index]);
        }

    }
}
