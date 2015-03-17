namespace LearnRx
{
    public class VideoTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public VideoTitle(int id, string title)
        {
            Id = id;
            Title = title;
        }

        protected bool Equals(VideoTitle other)
        {
            return Id == other.Id && string.Equals(Title, other.Title);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((VideoTitle) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id*397) ^ (Title?.GetHashCode() ?? 0);
            }
        }
    }
}