using api_learning_project.Model;
using System.Xml.Linq;

//New new new
namespace api_learning_project.Service
{
    public class GetSongsByArtist
    {
        private readonly ISongService songService;

        public GetSongsByArtist(ISongService songService)
        {
            this.songService = songService;
        }

        public List<Song> FindSongsByArtist(string artist)
        {
            if (string.IsNullOrWhiteSpace(artist))
            {
                return new List<Song>();
            }

            return songService
                .GetAllSongs()
                .Where(song => song.Artist.Contains(artist, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
