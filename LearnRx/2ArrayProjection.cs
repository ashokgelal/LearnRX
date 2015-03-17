using System.Collections.Generic;
using LearnRx.Extensions;

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
            return _dataSource.Map(release => new VideoTitle(release.Id, release.Title));
        }
    }
}
