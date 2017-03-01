using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntercomInvitation.DomainModel.Tests
{
    [TestClass()]
    public class LatLongTests
    {
        [TestMethod()]
        public void AssignmentTest()
        {
            LatLong assignment = new LatLong();
            Assert.AreEqual(0, assignment.Latitude);
            Assert.AreEqual(0, assignment.Longitude);

            assignment.Latitude = 52.986375;
            assignment.Longitude = -10.27699;
            Assert.AreEqual(52.986375, assignment.Latitude);
            Assert.AreEqual(-10.27699, assignment.Longitude);
        }

        [TestMethod()]
        public void EqualityTest()
        {
            LatLong e1 = new LatLong(52.986375, -6.043701),
                    e2 = new LatLong(53.3393, -6.2576841),
                    e3 = new LatLong(52.986375, -6.043701);

            Assert.AreEqual(e1, e1);
            Assert.AreNotEqual(e1, e2);
            Assert.AreNotEqual(e1, null);
            Assert.AreEqual(e1, e3);
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            LatLong e1 = new LatLong(53.3393, -6.2576841),
                    e2 = new LatLong(52.986375, -6.043701);

            LatLong expected = new LatLong(0.352925, -0.213983);
            Assert.AreEqual(expected, e1 - e2);

            expected = new LatLong(-0.352925, 0.213983);
            Assert.AreEqual(expected, e2 - e1);
        }
    }
}