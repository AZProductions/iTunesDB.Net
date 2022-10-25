using System;
using System.Linq;
using iTunesDB.Net.Readers;
using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class ReaderTests
    {
        [Test, Category("Reader")]
        public void CanCreateKnownObjectID()
        {
            var obj = iTunesReader.CreateReader("mhbd", null);
            Assert.AreEqual("mhbd", obj.ObjectID);
            Assert.AreEqual(typeof(MhbdReader), obj.GetType());
        }

        [Test, Category("Reader")]
        public void CannotCreateUnknownObjectID()
        {
            Assert.That(() => iTunesReader.CreateReader("xxxx", null), Throws.TypeOf<ArgumentException>());
        }

        [TestFixture]
        public class WithFilledDb : TestBase
        {
            [Test, Category("Reader")]
            public void CanOpenAndParse()
            {
                Assert.AreEqual(457, Reader.AllChildren.Count());
            }
        }

        [TestFixture]
        public class WithEmptyDb : TestBase
        {
            [Test, Category("Reader")]
            public void CanOpenAndParse()
            {
                Assert.AreEqual(74, ReaderEmpty.AllChildren.Count());
            }
        }
    }
}
