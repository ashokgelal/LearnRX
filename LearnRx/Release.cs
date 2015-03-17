using System;

namespace LearnRx
{
    public class Release
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Boxart { get; set; }
        public string Uri { get; set; }
        public float[] Rating { get; set; }
        public Tuple<int, int> Bookmark { get; set; }
    }
}