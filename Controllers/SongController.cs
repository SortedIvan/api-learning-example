using api_learning_project.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_learning_project.Controllers
{
    [ApiController]
    public class SongController : ControllerBase
    {
        private ISongService songService;

        public SongController(ISongService songService)
        {
            this.songService = songService;
        }

        [HttpPost("/api/createsong/")]
        public async Task<IActionResult> CreateSong(string genre, string title, int lengthInSeconds, string artist)
        {
            bool result = songService.CreateSong(genre, title, lengthInSeconds, artist);

            if (result)
            {
                return Ok("Your song was succesfully created");
            }

            return BadRequest("Something went wrong. Please try again");
        }
    }
}