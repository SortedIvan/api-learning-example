﻿using api_learning_project.Model;

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

        public List<Song> GetAllSongs() //New
        {
            return songs;
        }

        public List<Song> FindSongsByName(string name) //New
        {
            return songs.Where(s => s.Title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Song> FindSongsByArtist(string artist) //New
        {
            return songs.Where(s => s.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase)).ToList() ;
        }

    }
}
