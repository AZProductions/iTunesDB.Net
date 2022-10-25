using System.Linq;
using iTunesDB.Net.Database;
using iTunesDB.Net.Enumerations;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TrackListTests
    {
        [TestFixture]
        public class WithFilledDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void TrackList_TrackCount()
            {
                var rdrListContainer =
                    Reader.Children.FirstOrDefault(r => ((ListContainer) (r.DbObject)).ListType == ListTypes.Tracks);
                var rdrTrackList = rdrListContainer.Children.FirstOrDefault();

                Assert.AreEqual(23, Db.Tracks.Count);
                Assert.AreEqual(rdrTrackList.TotalSize, Db.Tracks.Count);
            }
        }

        [TestFixture]
        public class WithEmptyDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void TrackList_TrackCount()
            {
                var rdrListContainer =
                    ReaderEmpty.Children.FirstOrDefault(
                        r => ((ListContainer) (r.DbObject)).ListType == ListTypes.Tracks);
                var rdrTrackList = rdrListContainer.Children.FirstOrDefault();

                Assert.AreEqual(0, DbEmpty.Tracks.Count);
                Assert.AreEqual(rdrTrackList.TotalSize, DbEmpty.Tracks.Count);
            }
        }
    }
}
