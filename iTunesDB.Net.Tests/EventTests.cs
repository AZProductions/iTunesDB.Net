using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class EventTests
    {
        [Test, Category("Events")]
        public void Events_TrackRead()
        {
#if ASYNC
            var rdr = new MhbdReader();
            var tracks = new List<Track>();
            rdr.TrackRead += (object sender, TrackReadEventArgs e) =>
            {
                tracks.Add(e.Track);
                e.Cancel = e.Complete;
            };
            rdr.Open(TestBase.DbFilePath + "iTunesDB");
            Assert.AreEqual(rdr.Db.Tracks.Count, tracks.Count);
#endif
        }
    }
}
