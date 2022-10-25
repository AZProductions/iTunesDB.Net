using System;
using System.Linq;
using iTunesDB.Net.Database;
using iTunesDB.Net.Enumerations;
using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class AlbumItemTests
    {
        [TestFixture]
        public class WithFilledDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void AlbumItem_RockOrBust()
            {
                var album = Db.Albums.Cast<AlbumItem>().First(a => a.AlbumListAlbum == "Rock or Bust");

                Assert.AreEqual("AC/DC", album.AlbumListArtist);
                Assert.AreEqual("AC/DC", album.AlbumListArtistSort);
            }

            [Test, Category("iTunesDb")]
            public void AlbumItem_The_Silent_Enigma()
            {
                var album = Db.Albums.Cast<AlbumItem>().First(a => a.AlbumListAlbum == "The Silent Enigma");

                Assert.AreEqual("Anathema", album.AlbumListArtist);
                Assert.AreEqual("Anathema", album.AlbumListArtistSort);
            }

            [Test, Category("iTunesDb")]
            public void AlbumItem_Doom_Of_Destiny()
            {
                var album = Db.Albums.Cast<AlbumItem>().First(a => a.AlbumListAlbum == "Doom of Destiny");

                Assert.AreEqual("Axxis", album.AlbumListArtist);
                Assert.AreEqual("Axxis", album.AlbumListArtistSort);
            }

            [Test, Category("iTunesDb")]
            public void AlbumItem_13()
            {
                var album = Db.Albums.Cast<AlbumItem>().First(a => a.AlbumListAlbum == "13");

                Assert.AreEqual("Black Sabbath", album.AlbumListArtist);
                Assert.AreEqual("Black Sabbath", album.AlbumListArtistSort);
            }

//            [Test, Category("iTunesDb")]
//            public void Album_VideoItem_blink_182()
//            {
//                var album = Db.Albums.Cast<AlbumItem>().First(a => a.AlbumListAlbum == "13");
//
//                Assert.AreEqual("blink-182", album.AlbumListArtist);
//                Assert.AreEqual("Black Sabbath", album.AlbumListArtistSort);
//            }
//
//            [Test, Category("iTunesDb")]
//            public void Album_VideoItem_Sum_41()
//            {
//                var album = Db.Albums.Cast<AlbumItem>().First(a => a.AlbumListAlbum == "13");
//
//                Assert.AreEqual("Sum 41", album.AlbumListArtist);
//                Assert.AreEqual("Black Sabbath", album.AlbumListArtistSort);
//            }
        }
    }
}
