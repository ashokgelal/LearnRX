using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnRx.Tests
{
    [TestClass]
    public class ArrayProjectionTest
    {
        private Release[] _releases;

        public ArrayProjectionTest()
        {
            _releases = new[]
            {
                new Release
                {
                    Id = 70111470,
                    Title = "Die Hard",
                    Boxart = "http://cdn-0.nflximg.com/images/2891/DieHard.jpg",
                    Uri = "http://api.netflix.com/catalog/titles/movies/70111470",
                    Rating = new[] {4.0f},
                    Bookmark = null,
                },
                new Release
                {
                    Id = 654356453,
                    Title = "Bad Boys",
                    Boxart = "http://cdn-0.nflximg.com/images/2891/BadBoys.jpg",
                    Uri = "http://api.netflix.com/catalog/titles/movies/70111470",
                    Rating = new[] {5.0f},
                    Bookmark = new Tuple<int, int>(432534, 65876586),
                },
                new Release
                {
                    Id = 65432445,
                    Title = "The Chamber",
                    Boxart = "http://cdn-0.nflximg.com/images/2891/TheChamber.jpg",
                    Uri = "http://api.netflix.com/catalog/titles/movies/70111470",
                    Rating = new[] {4.0f},
                    Bookmark = null,
                },
                new Release
                {
                    Id = 675465,
                    Title = "Fracture",
                    Boxart = "http://cdn-0.nflximg.com/images/2891/Fracture.jpg",
                    Uri = "http://api.netflix.com/catalog/titles/movies/70111470",
                    Rating = new[] {5.0f},
                    Bookmark = new Tuple<int, int>(432213, 35876596),
                },
            };
        }
        [TestMethod]
        public void TestGetVideoAndTitlePairs()
        {
            var proj = new ArrayProjection(_releases);
            var titles = proj.GetVideoAndTitlePairs().ToList();
            Assert.AreEqual(4, titles.Count);
            Assert.AreEqual(new VideoTitle(70111470, "Die Hard"), titles[0]);
            Assert.AreEqual(new VideoTitle(654356453, "Bad Boys"), titles[1]);
            Assert.AreEqual(new VideoTitle(65432445, "The Chamber"), titles[2]);
            Assert.AreEqual(new VideoTitle(675465, "Fracture"), titles[3]);
        }
    }
}