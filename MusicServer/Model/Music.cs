namespace MusicServer.Model
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

        public override string ToString()
        {
            return Title + " - " + Artist;
        }
    }
}
