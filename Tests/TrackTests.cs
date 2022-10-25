using System;
using System.Linq;
using iTunesDB.Net.Database;
using iTunesDB.Net.Enumerations;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TrackTests
    {
        [TestFixture]
        public class WithFilledDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void AudioTrack_ACDC_Rock_or_Bust()
            {
                var playlists = Db.PlayLists.Cast<PlayList>().ToArray();
                var playlist = playlists.FirstOrDefault(p => p.Name == "Playlist Test");

                Assert.IsTrue(playlist != null);

                var trackId = playlist[0].TrackId;
                var track = Db.Tracks.Cast<Track>().First(t => t.TrackID == trackId);

                Assert.AreEqual(9, track.NumberOfStrings);
                Assert.AreEqual(4877, track.TrackID);
                Assert.AreEqual(true, track.Visible);
                Assert.AreEqual("MP3", track.FileType);
                Assert.AreEqual(CodingFormats.Mp3Vbr, track.CodingFormat);
                Assert.AreEqual(false, track.Compilation);
                Assert.AreEqual(0, track.Rating);
                Assert.AreEqual(new DateTime(2016, 8, 29, 13, 16, 54), track.LastModified);
                Assert.AreEqual(new TimeSpan(0, 0, 3, 3, 92), track.Length);
                Assert.AreEqual(1, track.TrackNumber);
                Assert.AreEqual(11, track.TrackCount);
                Assert.AreEqual(2014, track.Year);
                Assert.AreEqual(266, track.BitRate);
                Assert.AreEqual(44100.0d, track.SampleRate);
                Assert.AreEqual(0, track.Volume);
                Assert.AreEqual(TimeSpan.Zero, track.StartTime);
                Assert.AreEqual(null, track.StopTime);
                Assert.AreEqual(0, track.SoundCheck);
                Assert.AreEqual(1, track.PlayCount);
                Assert.AreEqual(0, track.PlayCountSinceLastSync);
                Assert.AreEqual(new DateTime(2019, 7, 11, 16, 23, 51), track.LastPlayed);
                Assert.AreEqual(1, track.DiscNumber);
                Assert.AreEqual(1, track.DiscCount);
                Assert.AreEqual(new DateTime(2016, 8, 29, 14, 16, 57), track.DateAdded);
                Assert.AreEqual(TimeSpan.Zero, track.BookmarkTime);
                Assert.AreEqual("180782E193C9C733", track.PersistentID);
                Assert.AreEqual(true, track.Checked);
                Assert.AreEqual(0, track.ApplicationRating);
                Assert.AreEqual(0, track.BPM);
                Assert.AreEqual(1, track.ArtworkCount);

                // ...

                Assert.AreEqual(MediaType.Audio, track.MediaType);


                //

                Assert.AreEqual("Rock or Bust", track.Name);
                Assert.AreEqual("MPEG-Audiodatei", track.Kind);
                Assert.AreEqual("Amazon.com Song ID: 251723621", track.Comments);
                Assert.AreEqual(null, track.Unknown3);
            }

            [Test, Category("iTunesDb")]
            public void VideoTrack_blink182_Always()
            {
                var playlists = Db.PlayLists.Cast<PlayList>().ToArray();
                var playlist = playlists.FirstOrDefault(p => p.Name == "Playlist Video");

                Assert.IsTrue(playlist != null);

                var trackId = playlist[0].TrackId;
                var track = Db.Tracks.Cast<Track>().First(t => t.TrackID == trackId);

                Assert.AreEqual(9, track.NumberOfStrings);
                Assert.AreEqual(5096, track.TrackID);
                Assert.AreEqual(true, track.Visible);
                Assert.AreEqual("M4V", track.FileType);
                Assert.AreEqual(CodingFormats.AAC, track.CodingFormat);
                Assert.AreEqual(false, track.Compilation);
                Assert.AreEqual(0, track.Rating);
                Assert.AreEqual(new DateTime(2019, 7, 11, 16, 23, 49), track.LastModified);
                Assert.AreEqual(new TimeSpan(0, 0, 4, 10, 355), track.Length);
                Assert.AreEqual(0, track.TrackNumber);
                Assert.AreEqual(0, track.TrackCount);
                Assert.AreEqual(2005, track.Year);
                Assert.AreEqual(125, track.BitRate);
                Assert.AreEqual(0.0d, track.SampleRate);
                Assert.AreEqual(0, track.Volume);
                Assert.AreEqual(TimeSpan.Zero, track.StartTime);
                Assert.AreEqual(null, track.StopTime);
                Assert.AreEqual(0, track.SoundCheck);
                Assert.AreEqual(0, track.PlayCount);
                Assert.AreEqual(0, track.PlayCountSinceLastSync);
                Assert.AreEqual(null, track.LastPlayed);
                Assert.AreEqual(0, track.DiscNumber);
                Assert.AreEqual(0, track.DiscCount);
                Assert.AreEqual(new DateTime(2006, 3, 22, 9, 57, 45), track.DateAdded);
                Assert.AreEqual(TimeSpan.Zero, track.BookmarkTime);
                Assert.AreEqual("4278A72B8765550F", track.PersistentID);
                Assert.AreEqual(true, track.Checked);
                Assert.AreEqual(0, track.ApplicationRating);
                Assert.AreEqual(0, track.BPM);
                Assert.AreEqual(1, track.ArtworkCount);

                // ...

                Assert.AreEqual(MediaType.MusicVideo, track.MediaType);


                //

                Assert.AreEqual("Always", track.Name);
                Assert.AreEqual("Gekaufte MPEG-4 Videodatei", track.Kind);
                Assert.AreEqual(null, track.Comments);
                Assert.AreEqual("Klaus Moster", track.Unknown3);
            }
        }
    }
}
