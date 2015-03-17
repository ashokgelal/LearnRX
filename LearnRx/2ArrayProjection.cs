using System.Collections.Generic;

namespace LearnRx
{
    public class ArrayProjection
    {
        private readonly IEnumerable<Release> _dataSource;

        public ArrayProjection(IEnumerable<Release> dataSource)
        {
            _dataSource = dataSource;
        }

        public IEnumerable<VideoTitle> GetVideoAndTitlePairs()
        {
            foreach (var release in _dataSource)
            {
                yield return new VideoTitle(release.Id, release.Title);
            }
        }
    }
}
