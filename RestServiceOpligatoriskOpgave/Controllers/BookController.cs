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
        private static readonly List<Book> Books = new List<Book>()
        {
            new Book("Harry Potter", "Gertrud", 560, "1234567890123"),
            new Book("Putta Horri", "Felix", 350, "3210987654321"),
            new Book("Game Of Thrones", "Samuel", 849, "2345678901234"),
            new Book("Scary Books", "Scarecrow", 234, "3456789012345"),
            new Book("SukaB", "Putin", 987, "4567890123456")
        };


        // GET: api/Book
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
