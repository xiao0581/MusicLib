using Microsoft.AspNetCore.Mvc;
using MusicServer.Model;
using System.Collections.Generic;



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

      

        // GET api/<MusicsController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public ActionResult<IEnumerable<Music>> GetBy([FromQuery] string? sortBy)
        {
            IEnumerable<Music> musicList= _musicRepository.GetSortBy(null);
            if (sortBy != null)
            {    

                musicList = _musicRepository.GetSortBy(sortBy);
            }

            if (musicList.Any())
            {
                return Ok(musicList);
            }
            else
            {
                return NotFound();
            }


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
