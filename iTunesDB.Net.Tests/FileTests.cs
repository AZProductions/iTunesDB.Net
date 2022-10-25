using System.IO;
using iTunesDB.Net.Readers;
using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class FileTests : TestBase
    {
        [Test, Category("Files")]
        public void ValidDbCanBeOpened()
        {
            Assert.IsNotNull(Db);
        }

        [Test, Category("Files")]
        public void InvalidDbCannotBeOpened()
        {
            Assert.That(() =>
                new MhbdReader().Open("C:\\INVALID_DIRECTORY\\INVALID_FILE"), Throws.TypeOf<FileNotFoundException>());
        }
    }
}
