﻿using Microsoft.VisualBasic;

namespace MusicServer.Model
{
    public class MusicRepository
        
    {
        private int _nextId = 3;
        private List<Music> _musics = new()
        {
            new Music() {Id = 1, Title = "Song1", Artist = "Artist1", Album = "Album1", Genre = "Genre", Year = 1997, Path = ""},
            new Music() {Id = 2, Title = "Song2", Artist = "Artist2", Album = "Album2", Genre = "Genre", Year = 1998, Path = ""},
            new Music() {Id = 3, Title = "Song3", Artist = "Artist3", Album = "Album3", Genre = "Genre", Year = 1999, Path = ""}
        };
        
        public void AddMusic(Music music)
        {
            
            music.Id = _nextId++;
            _musics.Add(music);
        }

        public void RemoveMusic(Music music)
        {
            _musics.Remove(music);
        }

        public List<Music> GetAllMusics()
        {
            return _musics;
        }

        public IEnumerable<Music> GetSortBy(string sortBy)

        {
            IEnumerable<Music> sortMusics = new List<Music>(_musics);
            if (sortBy != null) {
                switch (sortBy.ToLower())
                {
                    case "title":
                        sortMusics = _musics.OrderBy(m => m.Title);
                        break;
                    case "artist":
                        sortMusics = _musics.OrderByDescending(m => m.Artist);
                        break;
                    case "album":
                        sortMusics = _musics.OrderBy(m => m.Album);
                        break;
                    case "year":
                        sortMusics = _musics.OrderByDescending(m => m.Year);
                        break;

                }
            }
            
            return sortMusics;
        }

      
       public List<Music> DeleteMusic(int id)
        {
            return _musics.Where(m => m.Id != id).ToList();
        }
        public Music UpdateMusic(int id, Music music)
        {
            Music musicToUpdate = _musics.FirstOrDefault(m => m.Id == id);
            if (musicToUpdate != null)
            {
                musicToUpdate.Title = music.Title;
                musicToUpdate.Artist = music.Artist;
                musicToUpdate.Album = music.Album;
                musicToUpdate.Genre = music.Genre;
                musicToUpdate.Year = music.Year;
                musicToUpdate.Path = music.Path;
            }
            return musicToUpdate;
        }
        
    }
}
