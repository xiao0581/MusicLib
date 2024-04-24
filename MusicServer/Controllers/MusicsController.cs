using Microsoft.AspNetCore.Mvc;
using MusicServer.Model;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
            private MusicRepository _musicRepository;
        public MusicsController(MusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        // GET: api/<MusicsController>
        [HttpGet]
        public List<Music> GetAll()
        {
      
        }

        // GET api/<MusicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
