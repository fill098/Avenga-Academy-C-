using BooksAPI.Data;
using BooksAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int? index)
        {
            if (index == null)
            {
                return Ok(StaticDb.Books);
            }

            if (index < 0 || index >= StaticDb.Books.Count)
            {
                return NotFound($"There is no data at index {index}.");
            }

            return Ok(StaticDb.Books[index.Value]);
        }

        //[HttpGet("index")]
        //public ActionResult<Book> GetByIndex([FromQuery]int index)
        //{
        //    try
        //    {
        //        if (index < 0 || index >= StaticDb.Books.Count)
        //        {
        //            return NotFound($"There is no data on index {index}, make sure the index is positiv number!!");
        //        }
        //        return Ok(StaticDb.Books[index]);
        //    }
        //    catch (Exception ex)
        //    {

        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}

        [HttpGet("search")]
        public IActionResult GetByAuthorAndTitle([FromQuery]string? author, string? title)
        {
            var result  = StaticDb.Books.Where(x => (author == null || x.Author.ToLower().Contains(author.ToLower()))
            && (title == null || x.Title.ToLower().Contains(title.ToLower()))).ToList();

            if (result.Count == 0)
            {
                return NotFound($"There is not data with author:{author} and title:{title}!!");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest("Book data is required.");
            }

            if (string.IsNullOrEmpty(book.Author))
            {
                return BadRequest("Books author must have text.");
            }

            if (string.IsNullOrEmpty(book.Title))
            {
                return BadRequest("Title must have text");
            }
            
            StaticDb.Books.Add(book);
            return StatusCode(StatusCodes.Status201Created, book);
              
        }




    }
}
