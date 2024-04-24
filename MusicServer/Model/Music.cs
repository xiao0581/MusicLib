﻿namespace MusicServer.Model
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Path { get; set; }

        public Music(string title, string artist, string album, string genre, int year, string path)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Genre = genre;
            Year = year;
            Path = path;
        }

        public override string ToString()
        {
            return Title + " - " + Artist;
        }
    }
}