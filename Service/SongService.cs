using api_learning_project.Model;

namespace api_learning_project.Service
{
    public class SongService : ISongService
    { 
        private List<int> likedSongIds;
        private List<Song> songs;
        private int idCounter = 0;

        public SongService()
        {
            songs = new List<Song>();
            likedSongIds = new List<int>();
        }

        public Song GetSongById(int songId)
        {
            for (int i = 0; i < songs.Count; ++i)
            {
                if (songs[i].Id == songId)
                {
                    return songs[i];
                }
            }

            return null;
        }

        public bool AddSongToSystem(string genre, string title, int lengthInSeconds, string artist)
        {
            if (String.IsNullOrEmpty(genre) || String.IsNullOrEmpty(title) || String.IsNullOrEmpty(artist))
            {
                return false;
            }

            if(lengthInSeconds <= 0)
            {
                return false;
            } 

            Song song = new Song(idCounter++, genre, title, lengthInSeconds, artist);
            songs.Add(song);
            return true;
        }

        public List<Song> GetAllSongs() 
        {
            return songs;
        }

        public List<Song> FindSongsByName(string name) 
        {
            return songs.Where(s => s.Title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Song> FindSongsByArtist(string artist) 
        {
            return songs.Where(s => s.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase)).ToList() ;
        }

    }
}
