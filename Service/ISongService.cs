using api_learning_project.Model;

namespace api_learning_project.Service
{
    public interface ISongService
    {
        public bool CreateSong(string genre, string title, int lengthInSeconds, string artist);
        List<Song> GetAllSongs(); //New
    }
}
