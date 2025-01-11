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
        private readonly GetSongsByName getSongsByName; //New
        private readonly GetSongsByArtist getSongsByArtist; //New

        public SongController(ISongService songService, GetSongsByName getSongsByName, GetSongsByArtist getSongsByArtist)
        {
            this.songService = songService;
            this.getSongsByName = getSongsByName; //New
            this.getSongsByArtist = getSongsByArtist; // New
        }

        [HttpPost("createsong")]
        public IActionResult CreateSong(string genre, string title, int lengthInSeconds, string artist)
        {
            bool result = songService.CreateSong(genre, title, lengthInSeconds, artist);

            if (result)
            {
                return Ok("Your song was successfully created");
            }

            return BadRequest("Something went wrong. Please try again");
        }

        [HttpGet("getsongs")] //New
        public IActionResult GetSongs()
        {
            List<Song> songs = songService.GetAllSongs();
            if (!songs.Any())
            {
                return NotFound("No songs found");
            }
            return Ok(songs);
        }

        [HttpGet("getsongsbyname")] //New
        public IActionResult GetSongsByName(string name)
        {
            List<Song> songs = getSongsByName.FindSongsByName(name);
            if (!songs.Any())
            {
                return NotFound("No matching songs found");
            }
            return Ok(songs);
        }

        [HttpGet("getsongsbyartist")] //New
        public IActionResult GetSongsByArtist(string artist)
        {
            List<Song> songs = getSongsByArtist.FindSongsByArtist(artist);
            if (!songs.Any())
            {
                return NotFound("No matching songs found");
            }
            return Ok(songs);
        }
    }
}