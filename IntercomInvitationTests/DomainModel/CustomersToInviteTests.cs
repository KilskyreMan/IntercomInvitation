using IntercomInvitationTests.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace IntercomInvitation.DomainModel.Tests
{
    [TestClass()]
    public class CustomersToInviteTests
    {
        [TestMethod()]
        public void LivingWithin100KmTest()
        {
            List<Customer> expected = new List<Customer>();
            List<Customer> actual = CustomersToInvite.LivingWithin100Km(new IntercomCustomers());
            Assert.AreEqual(16, actual.Count, "Count within Range");
            int[] expectedIds = new int[16] { 4, 5, 6, 8, 11, 12, 13, 15, 17, 23, 24, 26, 29, 30, 31, 39 };
            for (int i = 0; i < 16; i++)
            {
                if (actual[i].Id != expectedIds[i])
                {
                    Assert.Fail(string.Format("Expected ID: {0}, Found: {1}", expectedIds[i], actual[i].Id));
                }
            }
        }
    }
}