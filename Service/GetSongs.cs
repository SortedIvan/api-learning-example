using api_learning_project.Model;

namespace api_learning_project.Service
{
    public class GetSongs
    {
        private ISongService songService;

        public GetSongs(ISongService songservice)
        {
            this.songService = songservice;
        }

        public List<Song> GetAllSongs()
        {
            return songService.GetAllSongs();
        }
    }
}
