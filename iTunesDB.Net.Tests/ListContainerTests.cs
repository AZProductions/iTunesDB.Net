using System.Linq;
using iTunesDB.Net.Database;
using iTunesDB.Net.Enumerations;
using NUnit.Framework;

namespace iTunesDB.Net.Tests
{
    [TestFixture]
    public class ListContainerTests : TestBase
    {
        [Test, Category("iTunesDb")]
        public void ListContainer_ListTypes()
        {
            int trackListContainers =
                Reader.Children.Count(c => ((ListContainer) c.DbObject).ListType == ListTypes.Tracks);
            int playListContainers =
                Reader.Children.Count(c => ((ListContainer) c.DbObject).ListType == ListTypes.PlayList);
            Assert.AreEqual(1, trackListContainers);
            Assert.AreEqual(1, playListContainers);
        }

        [Test, Category("iTunesDb")]
        public void ListContainer_Containers()
        {
            var x = Db.ListContainers;
        }
    }
}
