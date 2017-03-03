using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;
using ConstituencyTesting.Helper;
using TestedClass = Assignment_2.XMLPartyReader;

namespace ConstituencyTesting.Fixtures
{
    [TestClass]
    public class TestFixture_XmlPartyReader
    {
        TestedClass testedClass = null;
        [TestCleanup]
        public void TestsCleanup()
        {
            testedClass = null;
        }

        [TestMethod]
        [ExpectedException(typeof(System.Xml.XmlException))]
        public void Test_ReadParty_Method_List_Not_Exist()
        {
            // Arrange
            // A file with this name doesn not exist
            var filename = "InvalidConstituency.xml";

            // INstantiate an XmlPartyReader object
            testedClass = new TestedClass();

            // Act
            var partyList = testedClass.ReadPartyData(new ConfigRecord(filename));

            // Assert
            // Should not reach here due to exception being raised, if reached then force the test to fail
            Assert.Fail("ERROR: should have thrown System.Xml.XmlException before reaching here!");
        }

        [TestMethod]
        public void Test_ReadParty_Method_List_Sunderland()
        {
            // Arrange
            // Afile with this name does not exist
            var filename = "Sunderland.xml";

            // instantiate an XmlPartyReader object
            testedClass = new TestedClass();

            // Act
            var actualPartyList = testedClass.ReadPartyData(new ConfigRecord(filename));
            var expectedPartyList = Helper_KnownConstituencyData.GetSunderlandParty();

            // Assert
            // First assert the party list count
            Assert.AreEqual(actualPartyList.Count, expectedPartyList.Count);

            // iterate through the party list and check for data equality
            for (var i = 0; i < expectedPartyList.Count; i++)
            {
                Assert.AreEqual(expectedPartyList[i].partyName, actualPartyList[i].partyName);
                Assert.AreEqual(expectedPartyList[i].votes, actualPartyList[i].votes);
            }

        }
    }
}
