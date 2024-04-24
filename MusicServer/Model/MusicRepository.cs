namespace MusicServer.Model
{
    public class MusicRepository
        
    {
        private int _nextId = 3;
        private List<Music> _musics = new (){ 
         new Music("Song1", "Artist1", "Album1", "Genre1", 2021, "Path1"),
            new Music("Song2", "Artist2", "Album2", "Genre2", 2022, "Path2"),
            new Music("Song3", "Artist3", "Album3", "Genre3", 2023, "Path3"),            
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
