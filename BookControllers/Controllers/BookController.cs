using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObligatoriskOpgave;

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public static List<Bog> liste = new List<Bog>()
        {
            new Bog("Bog1","Mathias", 947, "1234567890111"),
            new Bog("Bog2", "Oliver", 22, "1234567890222"),
            new Bog("Bog3", "Oguz", 820, "1234567890333"),
            new Bog("Bog4", "Brink", 461, "1234567890444")
        };


        // GET: api/Book
        [HttpGet]
        public IEnumerable<Bog> Get()
        {
            return liste;
        }

        // GET: api/Book/5
        [HttpGet("{isbn13}", Name = "Get")]
        public Bog Get(string isbn13)
        {
            return liste.Find(b => b.Isbn13 == isbn13);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Bog value)
        {
            liste.Add(value);
        }

        // PUT: api/Book/5
        [HttpPut("{isbn13}")]
        public void Put(string isbn13, [FromBody] Bog value)
        {

            Bog bog = liste.Find(b => b.Isbn13 == isbn13);
            bog.Isbn13 = value.Isbn13;
            bog.Forfatter = value.Forfatter;
            bog.Sidetal = value.Sidetal;
            bog.Titel = value.Titel;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{isbn13}")]
        public void Delete(string isbn13)
        {
            Bog bog = liste.Find(b => b.Isbn13 == isbn13);
            liste.Remove(bog);

        }
    }
}
