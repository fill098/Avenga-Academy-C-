using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class02.ControllersAndActions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            return new List<string> { "value1", "value2" };
        }

        [HttpGet("info")]
        public string GetInfo()
        {
            return "This is a sample API controller.";
        }

        //[HttpGet]
        //public string GetString()
        //{
        //    return "Hello from ValuesController!";
        //}


        [HttpPost]

        public string Post()
        {
            return "OK";
        }

        [HttpGet("details/{id}")]

        public string GetById(int id)
        {
            return $"You requested value with ID: {id}";
        }
    }
}
