using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib
{
    public class MusicRepository
    {
        private List<Music> _musics = new List<Music>();

        public void AddMusic(Music music)
        {
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

        public List<Music> GetMusicsByArtist(string artist)
        {
            return _musics.Where(m => m.Artist == artist).ToList();
        }

        public List<Music> GetMusicsByGenre(string genre)
        {
            return _musics.Where(m => m.Genre == genre).ToList();
        }

        public List<Music> GetMusicsByYear(int year)
        {
            return _musics.Where(m => m.Year == year).ToList();
        }

        public List<Music> GetMusicsByAlbum(string album)
        {
            return _musics.Where(m => m.Album == album).ToList();
        }

    }
}
