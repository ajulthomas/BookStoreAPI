using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStoresDBContext _db;
        public BooksController(BookStoresDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("getBooks")]
        public IEnumerable<Book> GetBooks()
        {
            return _db.Books.ToList();
        }
    }
}
