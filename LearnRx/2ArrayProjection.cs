using System;
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
            // ------------   INSERT CODE HERE!  -----------------------------------
            // Use foreach loop to accumulate VideoTitle from each video and 
            // return the result.
            // ------------   INSERT CODE HERE!  -----------------------------------
            throw new NotImplementedException("Implement GetVideoAndTitlePairs()");
        }
    }
}
