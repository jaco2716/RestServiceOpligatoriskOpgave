using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookUnitTest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestServiceOpligatoriskOpgave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static readonly List<Book> books = new List<Book>()
        {
            new Book("Harry Potter", "Gertrud", 560, "1234567890123"),
            new Book("Putta Horri", "Felix", 350, "3210987654321"),
            new Book("Game Of Thrones", "Samuel", 849, "2345678901234"),
            new Book("Scary Books", "Scarecrow", 234, "3456789012345"),
            new Book("SukaB", "Putin", 987, "4567890123456")
        };


        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public Book Get(string isbn13)
        {
            return books.Find(i => i.Isbn13 == isbn13);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            books.Add(value);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(string isbn13, [FromBody] Book value)
        {
            Book book = Get(isbn13);
            if (book != null)
            {
                book.Title = value.Title;
                book.Auther = value.Auther;
                book.PageNo = value.PageNo;
                book.Isbn13 = value.Isbn13;
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string isbn13)
        {
            Book book = Get(isbn13);
            books.Remove(book);
        }
    }
}
