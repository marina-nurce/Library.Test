using Library.API.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private AppDbContext _context;
        public  LibraryController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("All")]
        public IActionResult GetLibrary()
        {
            var allBooks = _context.Books.ToList();
            return Ok(allBooks);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetBooksById(int id)
        {
            var newBooks = _context.Books
                .FirstOrDefault(n => n.Id == id);
            if (newBooks == null)
                return NotFound($"Book with id {id} could not be found.");
            return Ok(newBooks);
        }

        [HttpPost]
        public IActionResult AddNewBooks([FromBody] PostLibraryDto payload)
        {
            var newBooks = new Models.Books()
            {
                Title = payload.Title,
                Author = payload.Author,
                PublicationYear = payload.PublicationYear,

            };
            _context.Books.Add(newBooks);
            _context.SaveChanges();

             return Ok(payload);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateBooks([FromBody] PutLibraryDto payload, int id)
        {
            var LibraryDb = _context.Books
                .FirstOrDefault(n => n.Id == id);
            LibraryDb.Title = payload.Title;
            _context.Books.Update(LibraryDb);
            _context.SaveChanges();

           return Ok(payload);
        }
         
       [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteBooks(int id)
        {
            var LibraryDb = _context.Books
                .FirstOrDefault(n => n.Id == id);

            _context.Books.Remove(LibraryDb);
            _context.SaveChanges();
  
            return Ok();
        }

    }

}



    

