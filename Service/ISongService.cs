using api_learning_project.Model;

namespace api_learning_project.Service
{
    public interface ISongService
    {
        public bool AddSongToSystem(string genre, string title, int lengthInSeconds, string artist);
        public List<Song> GetAllSongs(); 
        public List<Song> FindSongsByName(string name);
        public List<Song> FindSongsByArtist(string artist);
        public bool LikeSongById(int songId);
        public Song GetSongById(int songId);
    }
}
