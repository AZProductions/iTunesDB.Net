using iTunesDB.Net.Enumerations;
using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class iTunesDbTests
    {
        [TestFixture]
        public class WithFilledDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void iTunesDb_FileName()
            {
                Assert.AreEqual(DbFileName, Db.FileName);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_FileSize()
            {
                Assert.AreEqual(57466, Db.FileSize);
                Assert.AreEqual(DbFileSize, Db.FileSize);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_Version()
            {
                Assert.AreEqual(115, Db.Version);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_Platform()
            {
                Assert.AreEqual(Platform.MacOs, Db.Platform);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_Language()
            {
                Assert.AreEqual("de", Db.Language);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_UnknownBytes()
            {
                Assert.AreEqual(56, Db.UnknownBytes.Length);
            }
        }

        [TestFixture]
        public class WithEmptyDb : TestBase
        {
            [Test, Category("iTunesDb")]
            public void iTunesDb_FileName()
            {
                Assert.AreEqual(DbEmptyFileName, DbEmpty.FileName);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_FileSize()
            {
                Assert.AreEqual(12634, DbEmpty.FileSize);
                Assert.AreEqual(DbEmptyFileSize, DbEmpty.FileSize);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_Version()
            {
                Assert.AreEqual(115, DbEmpty.Version);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_Platform()
            {
                Assert.AreEqual(Platform.MacOs, DbEmpty.Platform);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_Language()
            {
                Assert.AreEqual("de", DbEmpty.Language);
            }

            [Test, Category("iTunesDb")]
            public void iTunesDb_UnknownBytes()
            {
                Assert.AreEqual(56, DbEmpty.UnknownBytes.Length);
            }
        }
    }
}
