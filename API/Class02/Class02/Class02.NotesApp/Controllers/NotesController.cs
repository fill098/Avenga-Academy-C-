using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class02.NotesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(StaticDb.SimpleNotes);
        }

        [HttpGet("{id:int}")]

        public ActionResult<string> Get(int id)
        {
            if(id < 0 || id >= StaticDb.SimpleNotes.Count)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = $"Note with id {id} was not found."
                });
            }

            return Ok(StaticDb.SimpleNotes[id]);
        }

        [HttpPost]

        public ActionResult Post()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Request.Body))
                {
                    string newNote = sr.ReadToEnd();
                    if(string.IsNullOrWhiteSpace(newNote))
                    {
                        return BadRequest(new
                        {
                            StatusCode = 400,
                            Message = "Note title cannot be empty."
                        });
                    }

                    StaticDb.SimpleNotes.Add(newNote);
                    return StatusCode(StatusCodes.Status201Created, "The new Note created successfully.");
                    
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    StatusCode = 500,
                    Message = "An error occurred while processing the request."
                });

                throw;
            }
        }
    }
}
