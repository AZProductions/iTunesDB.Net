using System.Linq;
using iTunesDB.Net.Database;
using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class PlayListItemsTests
    {
        [TestFixture]
        public class WithFilledDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void PlayListItems_Tracks()
            {
                var playlists = Db.PlayLists.Cast<PlayList>().ToArray();
                var playlist = playlists.FirstOrDefault(p => p.Name == "Playlist Test");

                Assert.IsTrue(playlist != null);
                Assert.AreEqual(4, playlist.Count);

                var track1Id = playlist[0].TrackId;
                var track1 = Db.Tracks.Cast<Track>().First(t => t.TrackID == track1Id);
                Assert.AreEqual("Rock or Bust", track1.Name);

                var track2Id = playlist[1].TrackId;
                var track2 = Db.Tracks.Cast<Track>().First(t => t.TrackID == track2Id);
                Assert.AreEqual("Restless Oblivion", track2.Name);

                var track3Id = playlist[2].TrackId;
                var track3 = Db.Tracks.Cast<Track>().First(t => t.TrackID == track3Id);
                Assert.AreEqual("Voices Of Destiny", track3.Name);

                var track4Id = playlist[3].TrackId;
                var track4 = Db.Tracks.Cast<Track>().First(t => t.TrackID == track4Id);
                Assert.AreEqual("Live Forever", track4.Name);
            }
        }
    }
}
