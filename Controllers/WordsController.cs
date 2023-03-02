using Microsoft.AspNetCore.Mvc;


namespace WordleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        private static readonly string[] words = new string[10]
        { "apple" ,"bread", "climb", "dance", "every", "flour", "grape", "happy", "igloo", "juice" };

        // GET: api/<WordsController>
        [HttpGet("All")]
        public IEnumerable<string> Get()
        {
            return words;
        }

        // GET api/<WordsController>/5
        [HttpGet("Random")]
        public string GetOne()
        {
            return words[Random.Shared.Next(words.Length)];
        }

        [HttpGet("Ordered")]
        public IEnumerable<string> GetOrdered()
        {
            return words.OrderBy(x => x);
        }
    }
}
