using System;

namespace Music_Web_API.Model
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Singer { get; set; }
        public string Writer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
