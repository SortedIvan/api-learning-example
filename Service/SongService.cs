using api_learning_project.Model;

namespace api_learning_project.Service
{
    public class SongService : ISongService
    {
        private List<Song> songs;
        private int idCounter = 0;

        public SongService()
        {
            songs = new List<Song>();
        }

        public bool CreateSong(string genre, string title, int lengthInSeconds, string artist)
        {
            if (String.IsNullOrEmpty(genre) || String.IsNullOrEmpty(title))
            {
                return false;
            }

            Song song = new Song(idCounter++, genre, title, lengthInSeconds, artist);
            songs.Add(song);
            return true;
        }
    }
}
