using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IRepositoryManager _manager;
        public BooksController(IRepositoryManager manager)
        {
            _manager=manager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books = _manager.Book.GetAllBooks(false);
            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name="id")] int id)
        {
            try
            {
                var book = _manager.Book.GetOneBookById(id,false);

                if (book == null)
                {
                    return NotFound();
                }
                return Ok(book);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        public IActionResult CreateOneBook([FromBody] Book book)
        {
            try
            {
                if (book == null)
                {
                    return BadRequest();
                }
                _manager.Book.CreateOneBook(book);
                _manager.Save();
                return StatusCode(201,book);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute(Name="id")] int id, [FromBody] Book book )
        {
            try
            {
                var entity = _manager.Book.GetOneBookById(id,false); //güncellenecek kitabın bilgisini çekiyoruz

                if(entity == null)
                    return NotFound();

                if (id != book.Id)
                    return BadRequest();

                entity.Title = book.Title;
                entity.Price = book.Price;  //Sonraki aşamada Mapperlarla yapılacak
                _manager.Save();
                return Ok(book);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
