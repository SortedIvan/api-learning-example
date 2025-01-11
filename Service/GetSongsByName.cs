using api_learning_project.Model;

//New new new
namespace api_learning_project.Service
{
    public class GetSongsByName
    {
        private readonly ISongService songService;

        public GetSongsByName(ISongService songService)
        {
            this.songService = songService;
        }

        public List<Song> FindSongsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Song>();
            }

            return songService
                .GetAllSongs()
                .Where(song => song.Title.Contains(name, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
