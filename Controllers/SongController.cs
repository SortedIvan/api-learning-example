using api_learning_project.Model;
using api_learning_project.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_learning_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        private readonly ISongService songService;

        public SongController(ISongService songService)
        {
            this.songService = songService;
        }

        [HttpPost("createsong")]
        public IActionResult CreateSong(string genre, string title, int lengthInSeconds, string artist)
        {
            bool result = songService.AddSongToSystem(genre, title, lengthInSeconds, artist);

            if (result)
            {
                return Ok("Your song was successfully created");
            }

            return BadRequest("Something went wrong. Please try again");
        }

        [HttpGet("getsongs")] 
        public IActionResult GetSongs()
        {
            List<Song> songs = songService.GetAllSongs();
            if (!songs.Any())
            {
                return NotFound("No songs found");
            }
            return Ok(songs);
        }

        [HttpGet("getsongsbyname")] 
        public IActionResult GetSongsByName(string name)
        {
            List<Song> songs = songService.FindSongsByName(name);
            if (!songs.Any())
            {
                return NotFound("No matching songs found");
            }
            return Ok(songs);
        }

        [HttpGet("getsongsbyartist")] 
        public IActionResult GetSongsByArtist(string artist)
        {
            List<Song> songs = songService.FindSongsByArtist(artist);
            if (!songs.Any())
            {
                return NotFound("No matching songs found");
            }
            return Ok(songs);
        }
    }
}