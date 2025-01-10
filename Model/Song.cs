namespace api_learning_project.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }
        public string Artist { get; set; }

        public Song(int id,string genre, string title, int lengthInSeconds, string artist)
        {
            this.Id = id;
            Genre = genre;
            Title = title;
            Length = lengthInSeconds;
            Artist = artist;
        }

    }
}
