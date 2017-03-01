using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntercomInvitation.DomainModel.Tests
{
    [TestClass()]
    public class EarthTests
    {
        [TestMethod()]
        public void DistanceBetweenTest()
        {
            // Used http://www.movable-type.co.uk/scripts/latlong.html to
            // determine expected distances.

            LatLong DublinOffice = new LatLong(53.3393, -6.2576841),
                    DavidBehan = new LatLong(52.833502, -8.522366),
                    MichaelAhearn = new LatLong(52.966, -6.463),
                    OliveAhearn = new LatLong(53, -7);

            Assert.AreEqual(0, Earth.DistanceBetween(DublinOffice, DublinOffice), "DublinOffice");
            Assert.AreEqual(161.4, Earth.DistanceBetween(DublinOffice, DavidBehan), "DavidBehan");
            Assert.AreEqual(43.7, Earth.DistanceBetween(DublinOffice, MichaelAhearn), "MichaelAhearn");
            Assert.AreEqual(62.2, Earth.DistanceBetween(DublinOffice, OliveAhearn), "OliveAhearn");
        }
    }
}